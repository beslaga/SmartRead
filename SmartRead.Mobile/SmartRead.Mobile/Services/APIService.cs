using Flurl.Http;
using SmartRead.Model;
using SmartRead.Model.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SmartRead.Mobile.Services
{
    public class APIService
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static Korisnik PrijavljeniKorisnik { get; set; }

        private readonly string _route;

#if DEBUG
        private string APIUrl = "http://localhost:55992/api";
#endif
        public APIService(string route) // controller name
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search)
        {
            var url = $"{APIUrl}/{_route}";

            if (search != null)
            {
                url += "?";
                url += await search.ToQueryString();
            }

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }

        public async Task<T> GetById<T>(object id)
        {
            var url = $"{APIUrl}/{_route}/{id}";

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }

        public async Task<T> Insert<T>(object request, string action = null)
        {
            var url = $"{APIUrl}/{ _route}";
            if (action != null)
            {
                url += $"/{action}";
            }

            try
            {
                return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Error", stringBuilder.ToString(), "OK");
                return default(T);
            }

        }

        public async Task<T> Update<T>(int id, object request, string action = null)
        {
            try
            {
                var url = $"{APIUrl}/{ _route}";
                if (action != null)
                {
                    url += $"/{action}";
                }
                url += $"/{id}";

                return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Error", stringBuilder.ToString(), "OK");
                return default(T);
            }

        }

        public async Task<bool> Delete<T>(int id)
        {
            try
            {
                var url = $"{APIUrl}/{_route}/{id}";


                return await url.WithBasicAuth(Username, Password).DeleteAsync().ReceiveJson<bool>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Error", stringBuilder.ToString(), "OK");
                return false;
            }
        }
    }
}
