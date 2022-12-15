using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ImmersiveEducationSystem.Models;

namespace ImmersiveEducationSystem.Services.IServices {
    /// <summary>
    /// 身份验证服务
    /// </summary>
    public interface IAuthenticationService {
        /// <summary>
        /// 验证身份
        /// </summary>
        Task<AuthenticationResult> Authenticate();
    }
}