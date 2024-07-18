using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using TransactionsAPI.Process;
using TransactionsAPI.ViewModels;

namespace TransactionsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly IProfileProcess _profileProcess;
        public ProfileController(IProfileProcess profileProcess)
        {
            _profileProcess = profileProcess;
        }
        /// <summary>
        /// Create new profile (only name and email are mandatory fields)
        /// </summary>
        /// <param name="profileDto">profileDto</param>
        /// <returns></returns>
        [HttpPost("create")]
        [Produces(typeof(Guid))]
        public async Task<IActionResult> CreateProfileAsync([FromBody] ProfileDto profileDto)
        {
            if(profileDto is null || string.IsNullOrWhiteSpace(profileDto.UserName) || string.IsNullOrWhiteSpace(profileDto.Email))
            {
                return BadRequest("profile body is invalid");
            }
            try
            {
                var id = await _profileProcess.CreateProfileAsync(profileDto);
                return Ok(id);
            }
            catch(Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        /// <summary>
        /// Get the profile details
        /// </summary>
        /// <param name="profileId">profileId</param>
        /// <returns></returns>
        [HttpGet]
        [Produces(typeof(ProfileDto))]
        public async Task<IActionResult> GetProfileAsync([Required] Guid profileId)
        {            
            try
            {
                ProfileDto prf = null;
                prf = await _profileProcess.GetProfileAsync(profileId);
                if (prf is null)
                {
                    return NotFound($"no profile found with id = {profileId}");
                }
                return Ok(prf);
            }
            catch (Exception ex)
            {                
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        /// <summary>
        /// Update profile
        /// </summary>
        /// <param name="profile">profile</param>
        /// <returns></returns>
        [HttpPut]
        [Produces(typeof(bool))]
        public async Task<IActionResult> UpdateProfileAsync(ProfileDto profile)
        {
            try
            {
                bool res = await _profileProcess.UpdateProfileAsync(profile);
                if (res)
                {
                    return Ok("Profile updated successfully");
                }
                else
                {
                    return BadRequest("Profile couldn't be updated");
                }
            }
            catch(Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        /// <summary>
        /// Delete profile
        /// </summary>
        /// <param name="profileId">profileId</param>
        /// <returns></returns>
        [HttpDelete]
        [Produces(typeof(bool))]
        public async Task<IActionResult> DeleteProfileAsync([Required] Guid profileId)
        {
            try
            {
                bool res = await _profileProcess.DeleteProfileAsync(profileId);
                if (res)
                {
                    return Ok("Profile deleted");
                }
                else
                {
                    return BadRequest("Profile couldn't be deleted");
                }
            }
            catch(Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
