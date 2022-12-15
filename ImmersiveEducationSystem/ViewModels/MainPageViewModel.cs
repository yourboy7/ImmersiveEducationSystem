using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Xamarin.Forms;
using ImmersiveEducationSystem.Services.IServices;
using ImmersiveEducationSystem.Views;

namespace ImmersiveEducationSystem.ViewModels {
    /// <summary>
    /// 主页ViewModel
    /// </summary>
    public class MainPageViewModel : ViewModelBase {
        // ******** 构造函数

        //TODO 一堆服务

        /// <summary>
        /// 内容页激活服务
        /// </summary>
        private IContentPageActivationService _contentPageActivationService;

        /// <summary>
        /// 内容导航服务
        /// </summary>
        private IContentNavigationService _contentNavigationService;

        public MainPageViewModel(
            IContentPageActivationService contentPageActivationService,
            IContentNavigationService contentNavigationService) {
            _contentPageActivationService = contentPageActivationService;
            _contentNavigationService = contentNavigationService;
        }
        // ******** 绑定属性
        // ******** 绑定命令


        /// <summary>
        /// 页面显示命令。
        /// </summary>
        private RelayCommand _pageAppearingCommand;

        /// <summary>
        /// 页面显示命令。
        /// </summary>
        public RelayCommand PageAppearingCommand =>
            _pageAppearingCommand ?? (_pageAppearingCommand =
                new RelayCommand(async () =>
                    await PageAppearingCommandFunction()));

        public async Task PageAppearingCommandFunction()
        {
            if (_isLoaded)
                return;
            _isLoaded = true;

            //TODO 刘海处理
            NavigationPage.SetHasNavigationBar(MainPage, false);
            // NavigationPage.SetHasNavigationBar(
            //     _contentPageActivationService.Activate(
            //         ContentNavigationConstants.FileSystemPage), false);
            
            //TODO 数据填充处理
        }


        // ******** 公开变量
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
        /// MainPage
        /// </summary>
        public MainPage MainPage =>
            _mainPage ?? (_mainPage = NavigationPage.RootPage as MainPage);

        /// <summary>
        /// MainPage
        /// </summary>
        private MainPage _mainPage;

        /// <summary>
        /// 页面是否已经加载
        /// </summary>
        private volatile bool _isLoaded;
    }
}