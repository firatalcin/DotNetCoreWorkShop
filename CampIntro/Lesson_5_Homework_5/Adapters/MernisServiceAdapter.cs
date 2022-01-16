using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_5_Homework_5.Abstract;
using Lesson_5_Homework_5.Entities;
using MernisServiceReference;
using static MernisServiceReference.KPSPublicSoapClient;

namespace Lesson_5_Homework_5.Adapters
{
    internal class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckGamerService(Gamer gamer)
        {
            var mernisClient = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
            var tcKimlikDogrulamaServisResponse = mernisClient.TCKimlikNoDogrulaAsync
                ((gamer.NationalityId), gamer.FirstName, gamer.LastName, gamer.BirthYear).GetAwaiter().GetResult();
            return tcKimlikDogrulamaServisResponse.Body.TCKimlikNoDogrulaResult;
        }
    }
}
