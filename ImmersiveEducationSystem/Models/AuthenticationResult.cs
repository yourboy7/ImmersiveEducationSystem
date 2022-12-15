using System;
using System.Collections.Generic;
using System.Text;

namespace ImmersiveEducationSystem.Models {
    /// <summary>
    /// 身份验证结果
    /// </summary>
    public class AuthenticationResult {
        /// <summary>
        /// 访问Token
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// 是否存在错误
        /// </summary>
        public bool IsError { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        public string Error { get; set; }

        /// <summary>
        /// 身份验证结果
        /// </summary>
        public AuthenticationResult() { }

        /// <summary>
        /// 身份验证结果
        /// </summary>
        /// <param name="isError">是否存在错误</param>
        /// <param name="error">错误信息</param>
        public AuthenticationResult(bool isError, string error) {
            IsError = isError;
            Error = error;
        }
    }
}