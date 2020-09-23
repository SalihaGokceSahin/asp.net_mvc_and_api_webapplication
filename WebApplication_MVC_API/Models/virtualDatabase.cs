using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_MVC_API.Models
{
    public static class virtualDatabase
    {
        private static Dictionary<string,MeetingModel>_list;

        static virtualDatabase()
        {
            _list = new Dictionary<string, MeetingModel>();
            _list.Add("Amy", new MeetingModel
            {
                name = "Amy",
                email = "amy@amy.com",
                participationStatus = true
            });
            _list.Add("Hans", new MeetingModel
            {
                name = "Hans",
                email = "hans@hans.com",
                participationStatus = false
            });
            _list.Add("William", new MeetingModel { 
            name="William",
            email="william@william.com",
            participationStatus=true
            });


        }
        public static void Add(MeetingModel model)
        {
            string key = model.name.ToLower();
            if (_list.ContainsKey(key))
                _list[key] = model;
            else
                _list.Add(key, model);
        }
        public static IEnumerable<MeetingModel> List
        {
            get { return _list.Values; }
        }

    }
}