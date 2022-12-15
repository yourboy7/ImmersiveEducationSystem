using System;
using System.Collections.Generic;
using System.Text;
using GalaSoft.MvvmLight.Ioc;
using ImmersiveEducationSystem.Services.IServices;
using ImmersiveEducationSystem.Services.Realization;

namespace ImmersiveEducationSystem.ViewModels {
    /// <summary>
    /// ViewModel Locator
    /// </summary>
    public class ViewModelLocator {
        /// <summary>
        /// 初始化页ViewModel
        /// </summary>
        public InitializationPageViewModel InitializationPageViewModel =>
            SimpleIoc.Default.GetInstance<InitializationPageViewModel>();

        /// <summary>
        /// 主页ViewModel
        /// </summary>
        public MainPageViewModel MainPageViewModel =>
            SimpleIoc.Default.GetInstance<MainPageViewModel>();

        /// <summary>
        /// ViewModel Locator
        /// </summary>
        public ViewModelLocator() {
            SimpleIoc.Default
                .Register<IRootPageActivationService,
                    RootPageActivationService>();
            SimpleIoc.Default
                .Register<IRootNavigationService, RootNavigationService>();
            SimpleIoc.Default
                .Register<IContentPageActivationService,
                    ContentPageActivationService>();
            SimpleIoc.Default
                .Register<IContentNavigationService,
                    ContentNavigationService>();
            SimpleIoc.Default.Register<IPreferenceStorage, PreferenceStorage>();
            SimpleIoc.Default.Register<IAlertService, AlertService>();
            SimpleIoc.Default.Register<InitializationPageViewModel>();
            SimpleIoc.Default.Register<MainPageViewModel>();
        }
    }
}