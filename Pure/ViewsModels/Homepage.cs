using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pure.Models;

namespace Pure.ViewsModels
{
    public class Homepage
    {
        public List <Ads> Ads { get; set; }

        public List <Client> Clients { get; set; }

        public List <Popular> Populars { get; set; }

        public List <CodinBit> CodinBits { get; set; }

        public List <Recent> Recents { get; set; }

        public List <Promoted> Promoteds { get; set; }
    }
}