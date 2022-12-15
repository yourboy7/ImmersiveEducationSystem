using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ImmersiveEducationSystem.Services.IServices {
    /// <summary>
    /// 根导航服务接口
    /// </summary>
    public interface IRootNavigationService {
        /// <summary>
        /// 导航到页面
        /// </summary>
        /// <param name="pageKey">页面键</param>
        Task NavigateToAsync(string pageKey);

        /// <summary>
        /// 导航到页面
        /// </summary>
        /// <param name="pageKey">页面键</param>
        /// <param name="parameter">参数</param>
        /// <returns></returns>
        Task NavigateToAsync(string pageKey, object parameter);
    }

    /// <summary>
    /// 根导航常量
    /// </summary>
    public static class RootNavigationConstants {
        /// <summary>
        /// 主页
        /// </summary>
        public const string MainPage = nameof(Views.MainPage);

        /// <summary>
        /// 页面键-页面类型字典.
        /// </summary>
        public static readonly Dictionary<string, Type> PageKeyTypeDictionary =
            new Dictionary<string, Type> {
                { MainPage, typeof(Views.MainPage) }
            };
    }
}