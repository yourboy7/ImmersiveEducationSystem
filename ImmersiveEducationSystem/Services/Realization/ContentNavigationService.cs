using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ImmersiveEducationSystem.Services.IServices;

namespace ImmersiveEducationSystem.Services.Realization {
    /// <summary>
    /// 内容导航服务
    /// </summary>
    public class ContentNavigationService : IContentNavigationService {
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
        /// 内容页激活服务
        /// </summary>
        private IContentPageActivationService _contentPageActivationService;

        //*********继承方法

        /// <summary>
        /// 导航到页面
        /// </summary>
        /// <param name="pageKey">页面键</param>
        public async Task NavigateToAsync(string pageKey) {
            await NavigationPage.Navigation.PushAsync(
                _contentPageActivationService.Activate(pageKey));
        }

        /// <summary>
        /// 导航到页面
        /// </summary>
        /// <param name="pageKey">页面键</param>
        /// <param name="parameter">参数</param>
        /// <returns></returns>
        public async Task NavigateToAsync(string pageKey, object parameter) {
            var page = _contentPageActivationService.Activate(pageKey);
            NavigationContext.SetParameter1(page, parameter);
            await NavigationPage.Navigation.PushAsync(page);
        }

        /// <summary>
        /// 导航到页面
        /// </summary>
        /// <param name="pageKey">页面键</param>
        /// <param name="parameter1">参数1</param>
        /// <param name="parameter2">参数2</param>
        public async Task NavigateToAsync(string pageKey, object parameter1,
            object parameter2) {
            var page = _contentPageActivationService.Activate(pageKey);
            NavigationContext.SetParameter1(page, parameter1);
            NavigationContext.SetParameter2(page, parameter2);
            await NavigationPage.Navigation.PushAsync(page);
        }

        /// <summary>
        /// 导航到页面
        /// </summary>
        /// <param name="pageKey">页面键</param>
        /// <param name="parameter1">参数1</param>
        /// <param name="parameter2">参数2</param>
        /// <param name="parameter3">参数3</param>
        public async Task NavigateToAsync(string pageKey, object parameter1,
            object parameter2, object parameter3) {
            var page = _contentPageActivationService.Activate(pageKey);
            NavigationContext.SetParameter1(page, parameter1);
            NavigationContext.SetParameter2(page, parameter2);
            NavigationContext.SetParameter3(page, parameter3);
            await NavigationPage.Navigation.PushAsync(page);
        }

        // ******** 公开方法

        /// <summary>
        /// 内容导航服务
        /// </summary>
        /// <param name="contentPageActivationService">内容页激活服务</param>
        public ContentNavigationService(
            IContentPageActivationService contentPageActivationService) {
            _contentPageActivationService = contentPageActivationService;
        }
    }
}