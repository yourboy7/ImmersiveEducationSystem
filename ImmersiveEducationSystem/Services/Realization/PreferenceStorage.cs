using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using ImmersiveEducationSystem.Services.IServices;

namespace ImmersiveEducationSystem.Services.Realization {
    /// <summary>
    /// 偏好存储。
    /// </summary>
    public class PreferenceStorage : IPreferenceStorage {
        /// <param name="key">Preference key.</param>
        /// <param name="value">Preference value.</param>
        /// <summary>Sets a value for a given key.</summary>
        public void Set(string key, string value) {
            Preferences.Set(key, value);
        }

        /// <param name="key">Preference key.</param>
        /// <param name="defaultValue">Default value to return if the key does not exist.</param>
        /// <summary>Gets the value for a given key, or the default specified if the key does not exist.</summary>
        /// <returns>Value for the given key, or the default if it does not exist.</returns>
        public string Get(string key, string defaultValue) {
            return Preferences.Get(key, defaultValue);
        }

        /// <param name="key">Preference key.</param>
        /// <param name="value">Preference value.</param>
        /// <summary>Sets a value for a given key.</summary>
        public void Set(string key, int value) {
            Preferences.Set(key, value);
        }

        public int Get(string key, int defaultValue) {
            return Preferences.Get(key, defaultValue);
        }
    }
}