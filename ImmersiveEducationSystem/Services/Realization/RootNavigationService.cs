using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ImmersiveEducationSystem.Services.IServices;

namespace ImmersiveEducationSystem.Services.Realization {
    /// <summary>
    /// 根导航服务
    /// </summary>
    public class RootNavigationService : IRootNavigationService {
        // ******** 私有变量

        /// <summary>
        /// NavigationPage
        /// </summary>
        public NavigationPage NavigationPage =>
            _navigationPage ?? (_navigationPage =
                Application.Current.MainPage as NavigationPage);

        /// <summary>
        /// NavigationPage
        /// </summary>
        private NavigationPage _navigationPage;

        /// <summary>
        /// 根页面激活服务
        /// </summary>
        private IRootPageActivationService _rootPageActivationService;

        // ******** 继承方法

        /// <summary>
        /// 导航到页面
        /// </summary>
        /// <param name="pageKey">页面键</param>
        public async Task NavigateToAsync(string pageKey) {
            await NavigationPage.Navigation.PopToRootAsync();
            var page = _rootPageActivationService.Activate(pageKey);
            Application.Current.MainPage = page;

            if (Device.RuntimePlatform == Device.Android)
                await Task.Delay(100);
        }

        /// <summary>
        /// 导航到页面
        /// </summary>
        /// <param name="pageKey">页面键</param>
        /// <param name="parameter">参数</param>
        /// <returns></returns>
        public async Task NavigateToAsync(string pageKey, object parameter) {
            await NavigationPage.Navigation.PopToRootAsync();
            var page = _rootPageActivationService.Activate(pageKey);
            NavigationContext.SetParameter1(page.CurrentPage, parameter);
            Application.Current.MainPage = page;

            if (Device.RuntimePlatform == Device.Android)
                await Task.Delay(100);
        }

        // ******** 公开方法

        /// <summary>
        /// 根导航服务
        /// </summary>
        /// <param name="rootPageActivationService">根页面激活服务</param>
        public RootNavigationService(
            IRootPageActivationService rootPageActivationService) {
            _rootPageActivationService = rootPageActivationService;
        }
    }
}