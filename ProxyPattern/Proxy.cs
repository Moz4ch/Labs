using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Proxy : ISubject
    {
        private RealSubject _realSubject;
        private Dictionary<string, string> _cache;
        private DateTime _cacheTime;
        private TimeSpan _cacheExpiry = TimeSpan.FromSeconds(5);
        private string _userRole;

        public Proxy(string userRole)
        {
            _realSubject = new RealSubject();
            _cache = new Dictionary<string, string>();
            _cacheTime = DateTime.MinValue;
            _userRole = userRole;
        }

        public string Request(string request)
        {
            if (!HasAccess(request))
            {
                return "Отказано в доступе";
            }

            if (_cache.ContainsKey(request) && (DateTime.Now - _cacheTime) < _cacheExpiry)
            {
                Console.WriteLine("Proxy: Результат из кэша для " + request);
                return _cache[request];
            }
            var response = _realSubject.Request(request);

            _cache[request] = response;
            _cacheTime = DateTime.Now;

            return response;
        }

        private bool HasAccess(string request)
        {

            if (_userRole == "Admin")
            {
                Console.WriteLine("Proxy: Доступ предоставлен администратору.");
                return true;
            }

            if (_userRole == "User" && request.StartsWith("public"))
            {
                Console.WriteLine("Proxy: Доступ предоставлен пользователю.");
                return true;
            }

            Console.WriteLine("Proxy: Доступ отклонен.");
            return false;
        }
    }
}