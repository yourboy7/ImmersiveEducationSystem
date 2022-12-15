using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using ImmersiveEducationSystem.Services.IServices;

namespace ImmersiveEducationSystem.Services.Realization {
    /// <summary>
    /// 内容页激活服务
    /// </summary>
    public class ContentPageActivationService : IContentPageActivationService {
        // ******** 私有变量

        /// <summary>
        /// 页面缓存
        /// </summary>
        private Dictionary<string, ContentPage> cache =
            new Dictionary<string, ContentPage>();

        // ******** 继承方法

        /// <summary>
        /// 激活内容页
        /// </summary>
        /// <param name="pageKey">页面键</param>
        public ContentPage Activate(string pageKey) {
            return cache.ContainsKey(pageKey)
                ? cache[pageKey]
                : cache[pageKey] = (ContentPage)Activator.CreateInstance(
                    ContentNavigationConstants.PageKeyTypeDictionary[pageKey]);
        }
    }
}