using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ImmersiveEducationSystem.Services.Realization {
    /// <summary>
    /// 导航上下文
    /// </summary>
    public static class NavigationContext {
        /// <summary>
        /// 导航参数属性1
        /// </summary>
        public static readonly BindableProperty NavigationParameter1Property =
            BindableProperty.CreateAttached("NavigationParameter1",
                typeof(object), typeof(NavigationContext), null,
                BindingMode.OneWayToSource);

        /// <summary>
        /// 导航参数属性2
        /// </summary>
        public static readonly BindableProperty NavigationParameter2Property =
            BindableProperty.CreateAttached("NavigationParameter2",
                typeof(object), typeof(NavigationContext), null,
                BindingMode.OneWayToSource);

        /// <summary>
        /// 导航参数属性3
        /// </summary>
        public static readonly BindableProperty NavigationParameter3Property =
            BindableProperty.CreateAttached("NavigationParameter3",
                typeof(object), typeof(NavigationContext), null,
                BindingMode.OneWayToSource);

        /// <summary>
        /// 设置参数导航1
        /// </summary>
        /// <param name="bindableObject">需要设置导航参数的对象</param>
        /// <param name="value">导航参数</param>
        public static void SetParameter1(BindableObject bindableObject,
            object value) {
            bindableObject.SetValue(NavigationParameter1Property, value);
        }

        /// <summary>
        /// 设置参数导航2
        /// </summary>
        /// <param name="bindableObject">需要设置导航参数的对象</param>
        /// <param name="value">导航参数</param>
        public static void SetParameter2(BindableObject bindableObject,
            object value) {
            bindableObject.SetValue(NavigationParameter2Property, value);
        }

        /// <summary>
        /// 设置参数导航3
        /// </summary>
        /// <param name="bindableObject">需要设置导航参数的对象</param>
        /// <param name="value">导航参数</param>
        public static void SetParameter3(BindableObject bindableObject,
            object value) {
            bindableObject.SetValue(NavigationParameter3Property, value);
        }
    }
}