using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Just.Net.Models;

namespace Just.Net
{
    public interface IJustClient: IDisposable
    {
        bool IsOnline();
        Task<bool> IsOnlineAsync();
        IEnumerable<Sedinta> CautareSedinteAzi(Institutie institutie);
        IEnumerable<Sedinta> CautareSedinte(DateTime dataSedinta, Institutie institutie);
        Task<IEnumerable<Sedinta>> CautareSedinteAziAsync(Institutie institutie);
        Task<IEnumerable<Sedinta>> CautareSedinteAsync(DateTime dataSedinta, Institutie institutie);

        IEnumerable<Dosar> CautareDosareByNumar(string numarDosar);
        IEnumerable<Dosar> CautareDosareByNumeParte(string numeParte);
        IEnumerable<Dosar> CautareDosare(string numarDosar, string obiectDosar, string numeParte, Institutie? institutie = null, DateTime? dataStart = null, DateTime? dataStop = null);
        Task<IEnumerable<Dosar>> CautareDosareByNumarAsync(string numarDosar);
        Task<IEnumerable<Dosar>> CautareDosareByNumeParteAsync(string numeParte);
        Task<IEnumerable<Dosar>> CautareDosareAsync(string numarDosar, string obiectDosar, string numeParte, Institutie? institutie = null, DateTime? dataStart = null, DateTime? dataStop = null);
    }
}