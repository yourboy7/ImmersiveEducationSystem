using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using ImmersiveEducationSystem.Services.IServices;

namespace ImmersiveEducationSystem.Services.Realization {
    /// <summary>
    /// 根页面激活服务
    /// </summary>
    public class RootPageActivationService : IRootPageActivationService {
        // ******** 私有变量

        /// <summary>
        /// 页面缓存
        /// </summary>
        private Dictionary<string, NavigationPage> cache =
            new Dictionary<string, NavigationPage>();

        // ******** 继承方法

        /// <summary>
        /// 激活根页面
        /// </summary>
        /// <param name="pageKey">页面键</param>
        /// <returns></returns>
        public NavigationPage Activate(string pageKey) {
            return cache.ContainsKey(pageKey)
                ? cache[pageKey]
                : cache[pageKey] = new NavigationPage(
                    (ContentPage)Activator.CreateInstance(
                        RootNavigationConstants
                            .PageKeyTypeDictionary[pageKey]));
        }
    }
}