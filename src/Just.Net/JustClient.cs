using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Just.Net.InternalClient;
using Just.Net.Models;

namespace Just.Net
{
    public class JustClient : IJustClient
    {
        private readonly QuerySoapClient _soapClient;

        public JustClient()
        {
            _soapClient = new QuerySoapClient();
        }

        public bool IsOnline()
        {
            var ret = _soapClient.HelloWorld();
            return !string.IsNullOrEmpty(ret);
        }

        public async Task<bool> IsOnlineAsync()
        {
            var ret = await _soapClient.HelloWorldAsync();
            return !string.IsNullOrEmpty(ret?.Body?.HelloWorldResult);
        }

        public IEnumerable<Sedinta> CautareSedinteAzi(Institutie institutie)
        {
            return CautareSedinte(DateTime.Now, institutie);
        }

        public IEnumerable<Sedinta> CautareSedinte(DateTime dataSedinta, Institutie institutie)
        {
            var ret = _soapClient.CautareSedinte(dataSedinta, institutie);
            return ret ?? Enumerable.Empty<Sedinta>();
        }

        public async Task<IEnumerable<Sedinta>> CautareSedinteAziAsync(Institutie institutie)
        {
            return await CautareSedinteAsync(DateTime.Now, institutie);
        }

        public async Task<IEnumerable<Sedinta>> CautareSedinteAsync(DateTime dataSedinta, Institutie institutie)
        {
            var ret = await _soapClient.CautareSedinteAsync(dataSedinta, institutie);
            return ret?.Body?.CautareSedinteResult ?? Enumerable.Empty<Sedinta>();
        }

        public IEnumerable<Dosar> CautareDosareByNumar(string numarDosar)
        {
            return CautareDosare(numarDosar, null, null);
        }

        public IEnumerable<Dosar> CautareDosareByNumeParte(string numeParte)
        {
            return CautareDosare(null, null, numeParte);
        }

        public IEnumerable<Dosar> CautareDosare(string numarDosar, string obiectDosar, string numeParte, Institutie? institutie = null, DateTime? dataStart = null, DateTime? dataStop = null)
        {
            var ret  = _soapClient.CautareDosare(numarDosar, obiectDosar, numeParte, institutie, dataStart, dataStop);
            return ret ?? Enumerable.Empty<Dosar>();
        }

        public async Task<IEnumerable<Dosar>> CautareDosareByNumarAsync(string numarDosar)
        {
            return await CautareDosareAsync(numarDosar, null, null);
        }

        public async Task<IEnumerable<Dosar>> CautareDosareByNumeParteAsync(string numeParte)
        {
            return await CautareDosareAsync(null, null, numeParte);
        }

        public async Task<IEnumerable<Dosar>> CautareDosareAsync(string numarDosar, string obiectDosar, string numeParte, Institutie? institutie=null, DateTime? dataStart=null, DateTime? dataStop=null)
        {
            var ret = await _soapClient.CautareDosareAsync(numarDosar, obiectDosar, numeParte, institutie, dataStart, dataStop);
            return ret?.Body?.CautareDosareResult ?? Enumerable.Empty<Dosar>();
        }

        public void Dispose()
        {
            _soapClient.Close();
        }
    }
}