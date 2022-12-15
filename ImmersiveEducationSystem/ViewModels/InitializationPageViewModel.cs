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
    /// 初始化页ViewModel
    /// </summary>
    public class InitializationPageViewModel : ViewModelBase {
        // ******** 构造函数

        //TODO 一堆服务

        /// <summary>
        /// 根导航服务
        /// </summary>
        private IRootNavigationService _rootNavigationService;

        public InitializationPageViewModel(
            IRootNavigationService rootNavigationService) {
            _rootNavigationService = rootNavigationService;
        }
        // ******** 绑定属性
        // ******** 绑定命令

        /// <summary>
        /// 页面显示命令
        /// </summary>
        private RelayCommand _pageAppearingCommand;

        /// <summary>
        /// 页面显示命令
        /// </summary>
        public RelayCommand PageAppearingCommand =>
            _pageAppearingCommand ?? (_pageAppearingCommand =
                new RelayCommand(async () =>
                    await PageAppearingCommandFunction()));

        public async Task PageAppearingCommandFunction() {
            NavigationPage.SetHasNavigationBar(InitializationPage, false);

            //TODO 存储服务的初始化
            // if (!_rootDirItemStorage.IsInitialized())
            //     await _rootDirItemStorage.InitializeAsync();
            //
            // if (!_dirItemStorage.IsInitialized())
            //     await _dirItemStorage.InitializeAsync();
            //
            // if (!_userStorage.IsInitialized())
            //     await _userStorage.InitializeAsync();
            //
            // if (!_physicalDiskBlockStorage.IsInitialized())
            //     await _physicalDiskBlockStorage.InitializeAsync();
            //
            // if (!_diskBlockStorage.IsInitialized())
            //     await _diskBlockStorage.InitializeAsync();
            //
            // if (!_accessControlInfoStorage.IsInitialized())
            //     await _accessControlInfoStorage.InitializeAsync();

            await Task.Delay(1000);

            await _rootNavigationService.NavigateToAsync(RootNavigationConstants
                .MainPage);
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
        /// InitializationPage
        /// </summary>
        public InitializationPage InitializationPage =>
            _initializationPage ?? (_initializationPage =
                NavigationPage.RootPage as InitializationPage);

        /// <summary>
        /// InitializationPage
        /// </summary>
        private InitializationPage _initializationPage;
    }
}