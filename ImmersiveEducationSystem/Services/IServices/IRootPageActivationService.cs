using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ImmersiveEducationSystem.Services.IServices {
    /// <summary>
    /// 根页面激活服务接口
    /// </summary>
    public interface IRootPageActivationService {
        /// <summary>
        /// 激活根页面
        /// </summary>
        /// <param name="pageKey">页面键</param>
        /// <returns></returns>
        NavigationPage Activate(string pageKey);
    }
}