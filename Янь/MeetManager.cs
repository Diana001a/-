using System;
using System.Collections.Generic;
using System.Text;
using Янь.Models;

namespace Янь
{
    public class MeetManager
    {
        List<Meet> meets = new List<Meet>();
        public void AddNewMeet(string name, DateTime meetTime)
        {
            Meet newMeet = new Meet() { Name = name, CreateTime = DateTime.Now };
            meets.Add(newMeet);
        }
    }
}
