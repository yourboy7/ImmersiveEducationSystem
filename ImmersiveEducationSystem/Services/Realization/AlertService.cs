using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using ImmersiveEducationSystem.Services.IServices;

namespace ImmersiveEducationSystem.Services.Realization {
    /// <summary>
    /// 警告服务
    /// </summary>
    public class AlertService : IAlertService {
        // ******** 继承方法

        /// <summary>
        /// 显示警告
        /// </summary>
        /// <param name="page">显示警告的页面</param>
        /// <param name="title">标题</param>
        /// <param name="content">内容</param>
        /// <param name="button">按钮文字</param>
        public void DisplayAlert(ContentPage page, string title, string content,
            string button) {
            Device.BeginInvokeOnMainThread(() => {
                page.DisplayAlert(title, content, button);
            });
        }
    }
}