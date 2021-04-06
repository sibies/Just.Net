using System.Runtime.Serialization;

namespace Just.Net.Models
{
    [DataContract(Name = "StadiuProcesual", Namespace = "portalquery.just.ro")]
    public enum StadiuProcesual
    {
        [EnumMember] Fond = 0,

        [EnumMember] Apel = 1,

        [EnumMember] Recurs = 2,

        [EnumMember] Recursinanulare = 3,

        [EnumMember] Recursininteresullegii = 4,

        [EnumMember] Sesizareprealabila = 5,

        [EnumMember] ContestaţieNCPP = 6,

        [EnumMember] Recursincasatie = 7,

        [EnumMember] ContestatieICCJ = 8,

        [EnumMember] ContestatieInAnulareNCPP = 9,

        [EnumMember] RevizuireContestatieNCPP = 10,

        [EnumMember] Contestatie = 11,

        [EnumMember] Revizuire = 12,

        [EnumMember] Contestatieinanulare = 13,

        [EnumMember] Stabilireacompetentei = 14,

        [EnumMember] Recursimpotrivaincheierii = 15,

        [EnumMember] Recuzare = 16,

        [EnumMember] Stramutare = 17,

        [EnumMember] Indreptareeroaremateriala = 18,

        [EnumMember] ContestatieinanulareFond = 19,

        [EnumMember] ContestatieinanulareApel = 20,

        [EnumMember] ContestatieinanulareRecurs = 21,

        [EnumMember] RevizuireFond = 22,

        [EnumMember] RevizuireApel = 23,

        [EnumMember] RevizuireRecurs = 24
    }
}