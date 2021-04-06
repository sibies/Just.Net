using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Just.Net.Models;

namespace Just.Net
{
    public class NullJustClient: IJustClient
    {
      
        public bool IsOnline()
        {
            return true;
        }

        public Task<bool> IsOnlineAsync()
        {
            return Task.FromResult(true);
        }

        public IEnumerable<Sedinta> CautareSedinteAzi(Institutie institutie)
        {
            var result = Enumerable.Empty<Sedinta>();
            return result;
        }

        public IEnumerable<Sedinta> CautareSedinte(DateTime dataSedinta, Institutie institutie)
        {
            var result = Enumerable.Empty<Sedinta>();
            return result;
        }

        public Task<IEnumerable<Sedinta>> CautareSedinteAziAsync(Institutie institutie)
        {
            var result = Enumerable.Empty<Sedinta>();
            return Task.FromResult(result);
        }

        public Task<IEnumerable<Sedinta>> CautareSedinteAsync(DateTime dataSedinta, Institutie institutie)
        {
            var result = Enumerable.Empty<Sedinta>();
            return Task.FromResult(result);
        }

        public IEnumerable<Dosar> CautareDosareByNumar(string numarDosar)
        {
            var result = Enumerable.Empty<Dosar>();
            return result;
        }

        public IEnumerable<Dosar> CautareDosareByNumeParte(string numeParte)
        {
            var result = Enumerable.Empty<Dosar>();
            return result;
        }

        public IEnumerable<Dosar> CautareDosare(string numarDosar, string obiectDosar, string numeParte, Institutie? institutie = null,
            DateTime? dataStart = null, DateTime? dataStop = null)
        {
            var result = Enumerable.Empty<Dosar>();
            return result;
        }

        public Task<IEnumerable<Dosar>> CautareDosareByNumarAsync(string numarDosar)
        {
            var result = Enumerable.Empty<Dosar>();
            return Task.FromResult(result);
        }

        public Task<IEnumerable<Dosar>> CautareDosareByNumeParteAsync(string numeParte)
        {
            var result = Enumerable.Empty<Dosar>();
            return Task.FromResult(result);
        }

        public Task<IEnumerable<Dosar>> CautareDosareAsync(string numarDosar, string obiectDosar, string numeParte, Institutie? institutie = null,
            DateTime? dataStart = null, DateTime? dataStop = null)
        {
            var result = Enumerable.Empty<Dosar>();
            return Task.FromResult(result);
        }

        public void Dispose()
        {
        }

    }
}