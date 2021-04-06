using System.Runtime.Serialization;

namespace Just.Net.Models
{
    [DataContract(Name="DocumentSedinta", Namespace="portalquery.just.ro")]
    public enum DocumentSedinta
    {
        
        [EnumMember]
        Cerereinconstatarededrepturi = 0,
        
        [EnumMember]
        Cerereinrealizarededrepturi = 1,
        
        [EnumMember]
        Cereredeapel = 2,
        
        [EnumMember]
        Cererederecurs = 3,
        
        [EnumMember]
        Cererederecursinanulare = 4,
        
        [EnumMember]
        Cererederevizuire = 5,
        
        [EnumMember]
        Contestatieinanulare = 6,
        
        [EnumMember]
        Cererereconventionala = 7,
        
        [EnumMember]
        Cereredeinterventieininterespropriu = 8,
        
        [EnumMember]
        Cereredearatareatitularuluidreptului = 9,
        
        [EnumMember]
        Cereredechemareingarantie = 10,
        
        [EnumMember]
        Cereredestramutare = 11,
        
        [EnumMember]
        Plangereprealabila = 12,
        
        [EnumMember]
        Cereredereabilitare = 13,
        
        [EnumMember]
        Cereredeamanareaexecutariipedepsei = 14,
        
        [EnumMember]
        Cereredeintrerupereaexecutariipedepsei = 15,
        
        [EnumMember]
        Cereredeliberareconditionata = 16,
        
        [EnumMember]
        Contestatielaexecutare = 17,
        
        [EnumMember]
        Cerereprincaresesolicitaincetareaexecutariipedepseiloculdemunca = 18,
        
        [EnumMember]
        SentintaPenala = 19,
        
        [EnumMember]
        SentintaComerciala = 20,
        
        [EnumMember]
        Cererederecursininteresullegii = 21,
        
        [EnumMember]
        Cererederecunoastereahotararilorpronuntateinstrainatate = 22,
        
        [EnumMember]
        Cereredeincuviintareaexecutariisiliteahotararilorpronuntateinstrainatate = 23,
        
        [EnumMember]
        Actiuneintrodusadeadministratorsaulichidatorpentruanulareaunortransferuricucaracterpatrimonial = 24,
        
        [EnumMember]
        Cereredeaseridicadebitoruluidreptuldeasiconduceactivitatea = 25,
        
        [EnumMember]
        Cereredeabtinere = 26,
        
        [EnumMember]
        Cereredeinterventieininteresulalteipersoane = 27,
        
        [EnumMember]
        Cereredelegalizaredecopii = 28,
        
        [EnumMember]
        Cereredeconstatareaperimarii = 29,
        
        [EnumMember]
        Cererederepunereperol = 30,
        
        [EnumMember]
        Cererederestituireacautiunii = 31,
        
        [EnumMember]
        Cereredesuspendareaexecutarii = 32,
        
        [EnumMember]
        Cereredesuspendareaexecutariihotarariiintemeiulart300alin2si3Codproceduracivila = 33,
        
        [EnumMember]
        Cereredesuspendareaexecutariihotarariipecaleaordonanteipresedintiale = 34,
        
        [EnumMember]
        Contestatiadebitoruluicontracererilorintroductivealecreditorilorpentruincepereaprocedurii = 35,
        
        [EnumMember]
        Contestatiadebitoruluisaucreditoruluiimpotrivamasurilorluatedeadministratorlichidator = 36,
        
        [EnumMember]
        Contestatieimpotrivajudecatoruluisindicdeasecontinuaactivitateaincazdereorganizare = 37,
        
        [EnumMember]
        Cereredeacordareajutorpublicjudiciar = 38,
        
        [EnumMember]
        Altecereri = 39,
        
        [EnumMember]
        Copiehotarare = 40,
        
        [EnumMember]
        Actiuneinanulareahotarariiadunăriicreditorilor = 41,
        
        [EnumMember]
        Altecererin = 42,
        
        [EnumMember]
        Cererepentruantrenarearaspunderii = 43,
        
        [EnumMember]
        Cereredeanulareactefrauduloase = 44,
        
        [EnumMember]
        Cereredeanulareacteincheiateincursulprocedurii = 45,
        
        [EnumMember]
        Cereredeanularevanzaredirectaart118alin4 = 46,
        
        [EnumMember]
        Cereredeautorizareaexecutariisiliteîmpotrivaasociatiilormembrilornelimitatraspunzatori = 47,
        
        [EnumMember]
        Cereredeconfirmareaadministratoruluijudiciarlichidatoruldefinitivdesemnatdeadunarea = 48,
        
        [EnumMember]
        Cereredeconfirmareaplanuluidereorganizarejudiciara = 49,
        
        [EnumMember]
        Cererededesemnareacomitetuluicreditorilor = 50,
        
        [EnumMember]
        Cererededesemnareaunorpersoanedespecialitate = 51,
        
        [EnumMember]
        Cereredeincetareareorganizariisidetrecerelafaliment = 52,
        
        [EnumMember]
        Cereredeinchidereaprocedurii = 53,
        
        [EnumMember]
        Cereredeinlocuireaadministratoruluijudiciarlichidatorului = 54,
        
        [EnumMember]
        Cereredemodificareaplanuluidereorganizarejudiciara = 55,
        
        [EnumMember]
        Cererederidicareadreptuluidebitoruluideasiconduceactivitatea = 56,
        
        [EnumMember]
        Cererederidicareasuspendarii = 57,
        
        [EnumMember]
        Cereredesanctionareaadministratoruluilichidatoruluisideobligareladespagubiri = 58,
        
        [EnumMember]
        Cereredescoateredesuburmarireincadrulproceduriiaunuibun = 59,
        
        [EnumMember]
        Cerereaadministratoruluijudiciarlichidatoruluideinlocuireneculpabila = 60,
        
        [EnumMember]
        Cerereacreditoruluidedeschidereaproceduriigeneralesausimplificate = 61,
        
        [EnumMember]
        Cerereadebitoruluidedeschidereaproceduriigeneralesausimplificate = 62,
        
        [EnumMember]
        Contestatiadebitorului = 63,
        
        [EnumMember]
        Contestatieimpotrivahotarariiadunariicreditorilorcreditoruluimajoritardedesemnare = 64,
        
        [EnumMember]
        Contestatieimpotrivamasuriloradministratoruluijudiciarlichidatorului = 65,
        
        [EnumMember]
        Contestatielaraportuladministratoruluijudiciarlichidatorului = 66,
        
        [EnumMember]
        Contestatielaraportulplanuldedistribuirefonduri = 67,
        
        [EnumMember]
        Contestatielatabelulpreliminaralcreantelor = 68,
        
        [EnumMember]
        Contestatielatabeluldefinivalcreantelor = 69,
        
        [EnumMember]
        Obiectiilaraportulfinaldelichidare = 70,
        
        [EnumMember]
        Obiectiilaraportuldeevaluare = 71,
        
        [EnumMember]
        Opozitiacreditoruluiimpotrivaincheieriidedeschidereaproceduriilacerereadebitorului = 72,
        
        [EnumMember]
        Raportprocedurasimplificata = 73,
        
        [EnumMember]
        Alterapoarte = 74,
        
        [EnumMember]
        Mandatdeperchezitie = 75,
        
        [EnumMember]
        Mandatdearestarepreventiva = 76,
        
        [EnumMember]
        Mandatdearestarepreventivaemisintimpuljudecatii = 77,
        
        [EnumMember]
        Mandatuldeexecutareapedepseiinchisoriicontinut = 78,
        
        [EnumMember]
        incheierePerchezitie = 79,
        
        [EnumMember]
        incheierefinaladezinvestire = 80,
        
        [EnumMember]
        incheiereindreptareeroaremateriala = 81,
        
        [EnumMember]
        incheiereabtinere = 82,
        
        [EnumMember]
        incheiererecuzare = 83,
        
        [EnumMember]
        incheiereincuviintareascultare = 84,
        
        [EnumMember]
        Hotararecompletaredispozitiv = 85,
        
        [EnumMember]
        Cereresolicitaredeciziepenala = 86,
        
        [EnumMember]
        ConfirmaredeprimireAR = 87,
        
        [EnumMember]
        Confirmareprimireextrasdecizie = 88,
        
        [EnumMember]
        Cerereconexaredosare = 89,
        
        [EnumMember]
        Completaremotiverecursrevizuiresa = 90,
        
        [EnumMember]
        Adresadesolicitareaultimeiincheieridementinereaarestarii = 91,
        
        [EnumMember]
        Exceptiedeneconstitutionalitate = 92,
        
        [EnumMember]
        Adresasolicitarerelatiidelaaltainstanta = 93,
        
        [EnumMember]
        instiintaredeplataauneiamenzijudiciare = 94,
        
        [EnumMember]
        Notatelefonica = 95,
        
        [EnumMember]
        Cereredeacordareasistentajudiciara = 96,
        
        [EnumMember]
        AdresaBaroupentruacordareasistentajudiciara = 97,
        
        [EnumMember]
        Confirmaredeprimire = 98,
        
        [EnumMember]
        Acte = 99,
        
        [EnumMember]
        Adresadeexecutareaamenziijudiciare = 100,
        
        [EnumMember]
        incheieremasuripreventivefazadejudecata = 101,
        
        [EnumMember]
        Raportamanuntit = 102,
        
        [EnumMember]
        Raportasuprafondurilorobtinutedinvanzare = 103,
        
        [EnumMember]
        Tabelpreliminar = 104,
        
        [EnumMember]
        Raportfinal = 105,
        
        [EnumMember]
        Raportdeactivitate = 106,
        
        [EnumMember]
        Tabeldefinitiv = 107,
        
        [EnumMember]
        Tabelsuplimentar = 108,
        
        [EnumMember]
        Tabeldefinitivconsolidat = 109,
        
        [EnumMember]
        ContestatielaTabel = 110,
        
        [EnumMember]
        Actiuneinanulareactefrauduloase = 111,
        
        [EnumMember]
        Obiectiunilaraportuladministratoruluilichidatoruluijudiciar = 112,
        
        [EnumMember]
        Cerereinchidereprocedura = 113,
        
        [EnumMember]
        Contestatietergiversarecauza = 114,
        
        [EnumMember]
        Plangerecontestatietergiversare = 115,
        
        [EnumMember]
        Raportart493NCPC = 116,
        
        [EnumMember]
        Adresacomunicareraportart493NCPC = 117,
        
        [EnumMember]
        Rezolutie = 118,
        
        [EnumMember]
        IncheieresesizareICCJdatepersonale = 119,
        
        [EnumMember]
        Raportasuprachestiuniidedreptsupusejudecatii = 120,
        
        [EnumMember]
        Adresacomunicareraportfiltrusiconfirmaredeprimire = 121,
        
        [EnumMember]
        Hotararesesizareprealabilă = 122,
        
        [EnumMember]
        IncheieresesizareICCJpublic = 123,
        
        [EnumMember]
        Incheierecamerapreliminara = 124,
        
        [EnumMember]
        Cererepentrucontinuareaprocesuluipenalart18NCPP = 125,
        
        [EnumMember]
        Cererederenuntarelapretentiicivileart22NCPP = 126,
        
        [EnumMember]
        Incheieredeadmitereinprincipiu = 127,
        
        [EnumMember]
        Raportderecursincasatie = 128,
        
        [EnumMember]
        Mandatdesupravegheretehnica = 129,
        
        [EnumMember]
        Contestatieimpotrivamasuriiarestariipreventive = 130,
        
        [EnumMember]
        Comunicarelegalizareprinposta = 131,
        
        [EnumMember]
        Raportart439NCPP = 132,
        
        [EnumMember]
        Comunicareparchetcamerapreliminara = 133,
        
        [EnumMember]
        IncheiereInvestirecuformulaexecutorie = 134,
        
        [EnumMember]
        Incheierefinalacameraconsiliu = 135,
        
        [EnumMember]
        Rezolutietrimiterecompletinitial = 136,
        
        [EnumMember]
        Incheiereanularecerere = 137,
        
        [EnumMember]
        Incheierereexaminaredupăanularecerere = 138,
        
        [EnumMember]
        Hotararecameraconsiliu = 139,
        
        [EnumMember]
        Incheiereadmitereinprincipiu = 140,
        
        [EnumMember]
        Comunicareordindeprotectie = 141,
        
        [EnumMember]
        Incheierefinalacamerapreliminara = 142,
        
        [EnumMember]
        Incheierefinalamasuripreventivefazadejudecata = 143,
        
        [EnumMember]
        Plangere = 144,
        
        [EnumMember]
        Denunt = 145,
        
        [EnumMember]
        Sesizare = 146,
        
        [EnumMember]
        Plangereimpotrivamasuriiarestariipreventivedispusedeprocuror = 147,
        
        [EnumMember]
        Cereredeliberareprovizoriesubcontroljudiciar = 148,
        
        [EnumMember]
        Cereredeliberareprovizoriepecautiune = 149,
        
        [EnumMember]
        Plangereimpotrivamasurilorsiactelordeurmarirepenala = 150,
        
        [EnumMember]
        Rezolutiededisjungere = 151,
        
        [EnumMember]
        Hotararededisjungere = 152,
        
        [EnumMember]
        Cereredecontopireapedepselor = 153,
        
        [EnumMember]
        Cereredemodificareapedepseiconformart449Coddeprocedurapenala = 154,
        
        [EnumMember]
        Cereredeinlaturaresaumodificareapedepseiconformart458Coddeprocedurapenala = 155,
        
        [EnumMember]
        Plangereimpotrivaactelorsimasurilorprocurorului = 156,
        
        [EnumMember]
        Cereredeconfirmareamasuriiinternariimedicaleprovizorii = 157,
        
        [EnumMember]
        Cereredeinlocuireamasuriiinternariimedicale = 158,
        
        [EnumMember]
        Cereredeincetareamasuriiinternariiprovizorii = 159,
        
        [EnumMember]
        Cererederevocareamasuriidesiguranta = 160,
        
        [EnumMember]
        Cererederevocareasuspendariiexecutariipedepsei = 161,
        
        [EnumMember]
        Cereredeanulareasuspendariiexecutariipedepsei = 162,
        
        [EnumMember]
        Cererederevocareaexecutariipedepseilaloculdemunca = 163,
        
        [EnumMember]
        Cereredeanulareaexecutariipedepseilaloculdemunca = 164,
        
        [EnumMember]
        Declaratiedeapel = 165,
        
        [EnumMember]
        Declaratiederecurs = 166,
        
        [EnumMember]
        Cererederecuzare = 167,
        
        [EnumMember]
        Cereredeschimbarealoculuiexecutariipedepsei = 168,
        
        [EnumMember]
        Cereredeprelungireaarestariipreventive = 169,
        
        [EnumMember]
        Cereredeextradare = 170,
        
        [EnumMember]
        Cereredecomisierogatorie = 171,
        
        [EnumMember]
        Cereredetransferdeproceduripenale = 172,
        
        [EnumMember]
        Cereredeinmanaredeacte = 173,
        
        [EnumMember]
        Plangereimpotrivamasurilorasiguratorii = 174,
        
        [EnumMember]
        Cererederecunoastereahotararilorsiaaltoractejudiciarepronuntateinstrainatate = 175,
        
        [EnumMember]
        Cereredeinlocuireapedepsei = 176,
        
        [EnumMember]
        Cereredereconstituireadosarelorsauaaltorinscrisuri = 177,
        
        [EnumMember]
        Sesizareaorganuluicompetent = 178,
        
        [EnumMember]
        Cereredeindreptareauneierorimateriale = 179,
        
        [EnumMember]
        Certificat = 180,
        
        [EnumMember]
        Declaratiedepartevatamata = 181,
        
        [EnumMember]
        Mandatdearestareemisinlipsa = 182,
        
        [EnumMember]
        Procesverbaldeefectuareaactelorpremergatoare = 183,
        
        [EnumMember]
        Procesverbaldesesizaredinoficiu = 184,
        
        [EnumMember]
        Procesverbaldeconstatareafaptei = 185,
        
        [EnumMember]
        Procesverbaldeincepereaurmaririipenale = 186,
        
        [EnumMember]
        Procesverbaldecercetarelafatalocului = 187,
        
        [EnumMember]
        Procesverbaldeperchezitiesiridicaredeobiecte = 188,
        
        [EnumMember]
        Procesverbaldereconstituireafaptei = 189,
        
        [EnumMember]
        Procesverbaldeprezentareamaterialuluideurmarirepenala = 190,
        
        [EnumMember]
        Procesverbaldeinregistrariaudiosivideo = 191,
        
        [EnumMember]
        Procesverbaldeconfruntare = 192,
        
        [EnumMember]
        Procesverbalconformart91indice234 = 193,
        
        [EnumMember]
        Procesverbaldesechestrusiinscriptieipotecara = 194,
        
        [EnumMember]
        Procesverbaldeindreptareaerorilormateriale = 195,
        
        [EnumMember]
        Autorizatiedeinregistrarepebandamagneticaaunorconvorbiri = 196,
        
        [EnumMember]
        Autorizatiedeinregistrarepebandamagneticaaunorimagini = 197,
        
        [EnumMember]
        Autorizatieemisadeprocurorconformart111Cpp = 198,
        
        [EnumMember]
        Raportdeexpertiza = 199,
        
        [EnumMember]
        Raportdeexpertizacontabila = 200,
        
        [EnumMember]
        Raportdeexpertizatehnica = 201,
        
        [EnumMember]
        Raportdeexpertizapsihiatrica = 202,
        
        [EnumMember]
        Raportdeexpertizamedicolegala = 203,
        
        [EnumMember]
        Raportdeconstataretehnicostiintifica = 204,
        
        [EnumMember]
        Raportdeconstataremedicolegala = 205,
        
        [EnumMember]
        Ordonantacuprivirelamasurilepreventiveretinere = 206,
        
        [EnumMember]
        AvizalMinistruluiJustitieipentrumagistrati = 207,
        
        [EnumMember]
        executorijudecatorestisinotaridecercetare = 208,
        
        [EnumMember]
        AvizalParlamentului = 209,
        
        [EnumMember]
        Ordonantacuprivirelamasurilepreventivearestare = 210,
        
        [EnumMember]
        Ordonantacuprivirelamasurilepreventiveobligareadeanuparasilocalitatea = 211,
        
        [EnumMember]
        Memoriuderecursinanulare = 212,
        
        [EnumMember]
        Scrisoare = 213,
        
        [EnumMember]
        Memoriu = 214,
        
        [EnumMember]
        Opinie = 215,
        
        [EnumMember]
        Notadeaudienta = 216,
        
        [EnumMember]
        Cereritransferpersoanecondamnate = 217,
        
        [EnumMember]
        Informare = 218,
        
        [EnumMember]
        Rechizitoriu = 219,
        
        [EnumMember]
        SesizareacomisieidedisciplinaaMinisteruluiPublic = 220,
        
        [EnumMember]
        HotarareacomisieidedisciplinaaMinisteruluiPublic = 221,
        
        [EnumMember]
        Notaobservatorie = 222,
        
        [EnumMember]
        Cereredechemareinjudecata = 223,
        
        [EnumMember]
        Declaratiedeinculpat = 224,
        
        [EnumMember]
        Declaratiedeinvinuit = 225,
        
        [EnumMember]
        Declaratiedemartor = 226,
        
        [EnumMember]
        Declaratiedepartecivila = 227,
        
        [EnumMember]
        Declaratiedeparteresponsabilacivilmente = 228,
        
        [EnumMember]
        Mandatdearestare = 229,
        
        [EnumMember]
        Mandatdeaducere = 230,
        
        [EnumMember]
        Autorizatiedeperchezitie = 231,
        
        [EnumMember]
        Ordonantaaprocurorului = 232,
        
        [EnumMember]
        Procesverbaldeindeplinireaproceduriidecitare = 233,
        
        [EnumMember]
        Cazier = 234,
        
        [EnumMember]
        Cereredecontestareinanulare = 235,
        
        [EnumMember]
        incheiereSuspendare = 236,
        
        [EnumMember]
        incheieremasuripreventivefazadeUP = 237,
        
        [EnumMember]
        incheiereAmanareinitialaapronuntarii = 238,
        
        [EnumMember]
        incheiereAmanareulterioaraapronuntarii = 239,
        
        [EnumMember]
        incheieredesedinta = 240,
        
        [EnumMember]
        incheierePerimare = 241,
        
        [EnumMember]
        Hotarare = 242,
        
        [EnumMember]
        incheieredesedintasecreta = 243,
        
        [EnumMember]
        Acteindovedireacererii = 244,
        
        [EnumMember]
        Procesverbaldeconstatareainfractiunilordeaudienta = 245,
        
        [EnumMember]
        Cereredeinregistrareaudiosauvideo = 246,
        
        [EnumMember]
        Raportdeexpertizabalistica = 247,
        
        [EnumMember]
        Raportdeexpertizadactiloscopica = 248,
        
        [EnumMember]
        Altraportdeexpertiza = 249,
        
        [EnumMember]
        Alterapoartedeconstatari = 250,
        
        [EnumMember]
        Memoriuderecursininteresullegii = 251,
        
        [EnumMember]
        intampinare = 252,
        
        [EnumMember]
        Adresasolicitaretaxadetimbrutimbrujudiciarsicopiihotararijudecatoresti = 253,
        
        [EnumMember]
        Adresasolicitarecopiihotararijudecatoresti = 254,
        
        [EnumMember]
        Adresasolicitaretaxadetimbrusitimbrujudiciar = 255,
        
        [EnumMember]
        Adresasolicitaretaxadetimbru = 256,
        
        [EnumMember]
        Adresasolicitaretimbrujudiciar = 257,
        
        [EnumMember]
        Adresasolicitaredosar = 258,
        
        [EnumMember]
        Adresarestituiredosar = 259,
        
        [EnumMember]
        Adresaprecizareobiectmemoriu = 260,
        
        [EnumMember]
        Comunicaresolutietermenderecursinanulareexpirat = 261,
        
        [EnumMember]
        Comunicaresolutieanularememoriucanetimbrat = 262,
        
        [EnumMember]
        Comunicaresolutienusuntmotivederecursinanulare = 263,
        
        [EnumMember]
        Comunicaresolutiecauzaseaflaincursdejudecata = 264,
        
        [EnumMember]
        Comunicaresolutietransmiterememoriuorganuluicompetent = 265,
        
        [EnumMember]
        AdresacatreCSJdeinaintarerecursinanulare = 266,
        
        [EnumMember]
        Adresadeinstiintareainstanteidefondcasadeclaratrecursinanulare = 267,
        
        [EnumMember]
        Adresadeinstiintarepetentcasadeclaratrecursinanulare = 268,
        
        [EnumMember]
        Propunerepentrupromovarearecursuluiinanulare = 269,
        
        [EnumMember]
        Propunerepentrupromovarearecursuluiininteresullegii = 270,
        
        [EnumMember]
        Cereredecomunicaredeinformatii = 271,
        
        [EnumMember]
        Cereredeobtineredeacte = 272,
        
        [EnumMember]
        Referat = 273,
        
        [EnumMember]
        Nota = 274,
        
        [EnumMember]
        Citatie = 275,
        
        [EnumMember]
        Altecereri2 = 276,
        
        [EnumMember]
        Alteproceseverbale = 277,
        
        [EnumMember]
        Alteadrese = 278,
        
        [EnumMember]
        Rezolutiedeconexare = 279,
        
        [EnumMember]
        Comunicareasolutieicereriisauplangerii = 280,
        
        [EnumMember]
        Puneresubinterdictie = 281,
        
        [EnumMember]
        Declarareabandonminor = 282,
        
        [EnumMember]
        Apeluri = 283,
        
        [EnumMember]
        recursuri = 284,
        
        [EnumMember]
        contestatiideclaratedeprocurorsirespinse = 285,
        
        [EnumMember]
        Apelurirecursuricontestatiideclaratedepartipemotivedenelegalitate = 286,
        
        [EnumMember]
        Actiuniintemeiatepeprevederileart504CPP = 287,
        
        [EnumMember]
        Actiuniindreptateimpotrivaparchetului = 288,
        
        [EnumMember]
        Practicajudiciaraneunitara = 289,
        
        [EnumMember]
        Punereinexecutareatitlurilorcivile = 290,
        
        [EnumMember]
        Rezolutiaprocurorului = 291,
        
        [EnumMember]
        Ordonantadearestare = 292,
        
        [EnumMember]
        Ordonantadeconexare = 293,
        
        [EnumMember]
        Ordonantadedisjungere = 294,
        
        [EnumMember]
        Ordonantadescoateredesuburmarirepenala = 295,
        
        [EnumMember]
        Ordonantadeincetareaurmaririipenale = 296,
        
        [EnumMember]
        Ordonantadeclasare = 297,
        
        [EnumMember]
        Ordonantadeinfirmaresisauredeschidere = 298,
        
        [EnumMember]
        Ordonantaderestituireadosaruluilaorganuldecercetarepenala = 299,
        
        [EnumMember]
        Ordonantadepunereinmiscareaactiuniipenale = 300,
        
        [EnumMember]
        Ordonantadedeclinare = 301,
        
        [EnumMember]
        Rezolutiedeincepereaurmaririipenale = 302,
        
        [EnumMember]
        Rezolutiedescoateredesuburmarirepenala = 303,
        
        [EnumMember]
        Rezolutiedeincetareaurmaririipenale = 304,
        
        [EnumMember]
        Rezolutiedeclasare = 305,
        
        [EnumMember]
        Rezolutiedeinfirmaresisauredeschidere = 306,
        
        [EnumMember]
        Rezolutiededeclinare = 307,
        
        [EnumMember]
        Rezolutiederestituireadosaruluilaorganuldecercetarepenala = 308,
        
        [EnumMember]
        Rezolutiedetrecereacauzeidelaunorganlaaltul = 309,
        
        [EnumMember]
        Rezolutiedeneincepereaurmaririipenale = 310,
        
        [EnumMember]
        AvizalMinistruluiJustitieipentrumagistratiexecutorijudecatorestisinotaridetrimitereinjudecata = 311,
        
        [EnumMember]
        Cerereinlocuiremasuraarestariipreventiveart139CPP = 312,
        
        [EnumMember]
        Procesverbaldeaducerelacunostintaainvinuiriisiadreptuluilaaparare = 313,
        
        [EnumMember]
        Anchetasociala = 314,
        
        [EnumMember]
        Procesverbalderecunoasteredingrup = 315,
        
        [EnumMember]
        Plansafotografica = 316,
        
        [EnumMember]
        ReferatdeterminareaurmaririipenaleintocmitdeorganeledePolitie = 317,
        
        [EnumMember]
        Cereredeincetareamunciicorectionale = 318,
        
        [EnumMember]
        Cererepentruinlocuireapedepseiamenziicuinchisoarea = 319,
        
        [EnumMember]
        Cererepentruinlocuireapedepseidetentiuniipeviatacupedeapsainchisorii = 320,
        
        [EnumMember]
        Declaratiedeabtinere = 321,
        
        [EnumMember]
        Ordonantadeadmiteriicereriideliberareprovizoriesubcontroljudiciar = 322,
        
        [EnumMember]
        Ordonantaderespingereacereriideliberareprovizoriesubcontroljudiciar = 323,
        
        [EnumMember]
        Ordonantadeadmitereacereriideliberareprovizoriepecautiune = 324,
        
        [EnumMember]
        Ordonantaderespingereacereriideliberareprovizoriepecautiune = 325,
        
        [EnumMember]
        Ordonantadeluareamasurilorasiguratorii = 326,
        
        [EnumMember]
        Ordonantadeinterzicerealuariidecontactaaparatoruluicuinculpatul = 327,
        
        [EnumMember]
        Ordonantadeaplicareauneiamenzijudiciare = 328,
        
        [EnumMember]
        Ordonantadescoateredesuburmarirepenalasiaplicareauneisanctiunicucaracteradministrativ = 329,
        
        [EnumMember]
        Ordonantadesuspendareaurmaririipenale = 330,
        
        [EnumMember]
        Ordonantadeadmitereacererilornoiformulatedeinculpat = 331,
        
        [EnumMember]
        Ordonantaderespingereacererilornoiformulatedeinculpat = 332,
        
        [EnumMember]
        Ordonantadetrimitereacauzeilaunaltorgandeurmarireinvedereacompletariisaurefaceriiacesteia = 333,
        
        [EnumMember]
        Ordonantadereluareaurmaririipenale = 334,
        
        [EnumMember]
        Rezolutiedeefectuareauneiconstataritehnicostiintifice = 335,
        
        [EnumMember]
        Rezolutiedeefectuareaunoracteproceduraleprincomisierogatorie = 336,
        
        [EnumMember]
        Rezolutiededelegare = 337,
        
        [EnumMember]
        Rezolutiedeluareamasurilordesiguranta = 338,
        
        [EnumMember]
        Rezolutiederestituirealucrurilor = 339,
        
        [EnumMember]
        Rezolutiedeindreptareaerorilormateriale = 340,
        
        [EnumMember]
        Rezolutiedeinlaturareaunoromisiunivadite = 341,
        
        [EnumMember]
        Rezolutiedeextindereacercetariipenale = 342,
        
        [EnumMember]
        Rezolutiedeinlocuireamasurilorpreventive = 343,
        
        [EnumMember]
        Rezolutiederevocareamasurilorpreventive = 344,
        
        [EnumMember]
        Rezolutiedeadmitereaplangeriiimpotrivamasurilorsiactelordeurmarirepenala = 345,
        
        [EnumMember]
        Rezolutiederespingereaplangeriiimpotrivamasurilorsiactelordeurmarirepenala = 346,
        
        [EnumMember]
        Cereredereexaminare = 347,
        
        [EnumMember]
        Notatelefonica2 = 348,
        
        [EnumMember]
        Rezolutiedeinchidere = 349,
        
        [EnumMember]
        Referatdeinchidere = 350,
        
        [EnumMember]
        Referatdereexaminare = 351,
        
        [EnumMember]
        Cereredecomunicareasolutieicereriisauplangerii = 352,
        
        [EnumMember]
        Cereredeanulareareabilitarii = 353,
        
        [EnumMember]
        Cererederevocareaarestarii = 354,
        
        [EnumMember]
        Cererepentruconstatareaincetariidedreptaarestarii = 355,
        
        [EnumMember]
        Cereredecontestareamasurilorasiguratorii = 356,
        
        [EnumMember]
        Cerereinprobatoriu = 357,
        
        [EnumMember]
        Fotografii = 358,
        
        [EnumMember]
        Cereripentrumajorareaonorariilorexpertilorsiinterpretilor = 359,
        
        [EnumMember]
        Cereripentrucheltuielidejudecatadinparteamartorilor = 360,
        
        [EnumMember]
        Obiectivedeexpertizacerutedepartisaudeprocuror = 361,
        
        [EnumMember]
        Memoriudepromovarerevizuiredecatreprocuror = 362,
        
        [EnumMember]
        Memoriudepromovarecontestatieinanularedecatreprocuror = 363,
        
        [EnumMember]
        Actenotariale = 364,
        
        [EnumMember]
        Altedocumente = 365,
        
        [EnumMember]
        Adresasupraveghere = 366,
        
        [EnumMember]
        Adresadeinaintaretrimiteredosar = 367,
        
        [EnumMember]
        Cererestudiudosar = 368,
        
        [EnumMember]
        Adresasolicitaredatesauinformatii = 369,
        
        [EnumMember]
        Adresasolicitareacte = 370,
        
        [EnumMember]
        Comunicaresolutiedosar = 371,
        
        [EnumMember]
        Comunicareptrplataamenziiadministrativesicheltuielijudiciare = 372,
        
        [EnumMember]
        Referatpunereinmiscareaactiuniipensiarestarepreventiva = 373,
        
        [EnumMember]
        Cereredeinscriereinfals = 374,
        
        [EnumMember]
        Cereredecompletareauneiomisiuni = 375,
        
        [EnumMember]
        Cererederevizuireahotararii = 376,
        
        [EnumMember]
        Cereredeindreptareahotararii = 377,
        
        [EnumMember]
        Cereredecompletareahotararii = 378,
        
        [EnumMember]
        Cerereptlamurireaintelesuluiintinderiisauaplicariidispozitivuluihotararii = 379,
        
        [EnumMember]
        Cereredepreschimbareatermenuluidejudecata = 380,
        
        [EnumMember]
        Cereredestabilireacautiunii = 381,
        
        [EnumMember]
        Cereredeanulareaunuititluhotarariarbitraleetc = 382,
        
        [EnumMember]
        Cereredesuspendareahotararii = 383,
        
        [EnumMember]
        Cereredepoprireasiguratorie = 384,
        
        [EnumMember]
        Actiuneinconstatareanulitatiiabsoluteaunuiactjuridic = 385,
        
        [EnumMember]
        Actiuneinanulare = 386,
        
        [EnumMember]
        Cereredestabilireacompetentei = 387,
        
        [EnumMember]
        Cererepentrulipsadeaparare = 388,
        
        [EnumMember]
        Cereredeamanareaplatiitaxeidetimbru = 389,
        
        [EnumMember]
        Cereredescutireaplatiitaxeidetimbru = 390,
        
        [EnumMember]
        Cereredesuspendareajudecatii = 391,
        
        [EnumMember]
        Cereredecitarelaaltaadresa = 392,
        
        [EnumMember]
        Cereredecitareprinafisare = 393,
        
        [EnumMember]
        Dovadadeindeplinireaproceduriidecitare = 394,
        
        [EnumMember]
        Notescrise = 395,
        
        [EnumMember]
        Dovadadeachitaretaxadetimbru = 396,
        
        [EnumMember]
        Contestatieinmoduldestabilireataxeidetimbru = 397,
        
        [EnumMember]
        Cereredeintroducereaaltorparti = 398,
        
        [EnumMember]
        Motivederecurs = 399,
        
        [EnumMember]
        Actenoipentrucomunicarearecurentului = 400,
        
        [EnumMember]
        Actenoipentrucomunicareaintimatului = 401,
        
        [EnumMember]
        Anuntareaschimbariisediuluisaudenumirii = 402,
        
        [EnumMember]
        Comunicare = 403,
        
        [EnumMember]
        Ordonanta = 404,
        
        [EnumMember]
        Cereredecomunicaresolutiedosar = 405,
        
        [EnumMember]
        Cereredecomunicarestadiucercetari = 406,
        
        [EnumMember]
        Cerereavizcercetare = 407,
        
        [EnumMember]
        Cerereaviztrimitereinjudecata = 408,
        
        [EnumMember]
        Fisacriminologica = 409,
        
        [EnumMember]
        OrdinalMinistruluiJustitieipentruextradare = 410,
        
        [EnumMember]
        Ordonantaderevocareamasuriiarestariipreventive = 411,
        
        [EnumMember]
        Comunicaremotivedeapel = 412,
        
        [EnumMember]
        Comunicareahotararilorcivileprivindadoptiaunorminori = 413,
        
        [EnumMember]
        Comunicareahotararilorcivileprivinddesfacereaunoradoptii = 414,
        
        [EnumMember]
        Comunicareahotararilorcivileprivindpunereasubinterdictie = 415,
        
        [EnumMember]
        Comunicareahotararilorcivileprivindincheiereadesentintecivile = 416,
        
        [EnumMember]
        Comunicareahotararilorcivileprivindinregistrareapartidelorpolitice = 417,
        
        [EnumMember]
        Comunicareahotararilorcivileprivindinregistrareaaliantelorpolitice = 418,
        
        [EnumMember]
        Comunicareahotararilorcivileprivindmodificareastatutuluipartidelorpolitice = 419,
        
        [EnumMember]
        Comunicareahotararilorcivileprivindmodificareastatutuluialiantelorpolitice = 420,
        
        [EnumMember]
        Comunicareahotararilorcivileprivindfuziuneapartidelorpolitice = 421,
        
        [EnumMember]
        Comunicareahotararilorcivileprivindfuziuneaaliantelorpolitice = 422,
        
        [EnumMember]
        Comunicareahotararilorcivileprivinddizolvareapartidelorpolitice = 423,
        
        [EnumMember]
        Comunicareahotararilorcivileprivinddizolvareaaliantelorpolitice = 424,
        
        [EnumMember]
        Comunicareahotararilorcivileprivindinfiintareasindicatelor = 425,
        
        [EnumMember]
        Comunicareahotararilorcivileprivindinfiintareauniunilorfederatiilorsauconfederatiilordesindicat = 426,
        
        [EnumMember]
        Comunicareahotararilorcivileprivindmodificareastatutuluisindicateloruniunilorfederatiilorsauconfederatiilordesindicat = 427,
        
        [EnumMember]
        Comunicareahotararilorcivileprivindinregistrari = 428,
        
        [EnumMember]
        modificarisaudizolvarideasociatiisifundatii = 429,
        
        [EnumMember]
        Comunicareahotararilorcivileprivinddecaderidindrepturiparintesti = 430,
        
        [EnumMember]
        Comunicareahotararilorcivileprivinddeclarareadisparitiilor = 431,
        
        [EnumMember]
        Comunicareahotararilorcivileprivinddeclarareamortiiprezumate = 432,
        
        [EnumMember]
        Comunicareahotararilorcivileprivindinregistrareasirectificareaunoractecivile = 433,
        
        [EnumMember]
        Comunicareahotararilorcivileprivindnulitateaadoptiei = 434,
        
        [EnumMember]
        ComunicareahotararilorcivileprivindanulareaunoracteadministrativeconfOG132001 = 435,
        
        [EnumMember]
        Comunicareahotararilorcivileprivindactiunilededespagubireconfart504CPP = 436,
        
        [EnumMember]
        Comunicareahotararilorcivileprivindactiunilestatuluideexproprierepentrucauzedeutilitate = 437,
        
        [EnumMember]
        Comunicarecitatii = 438,
        
        [EnumMember]
        Comunicareahotararilorcivileprivindcerereadedeclararejudecatoreascaaabandonului = 439,
        
        [EnumMember]
        incheieredesedinta2 = 440,
        
        [EnumMember]
        Decizie = 441,
        
        [EnumMember]
        Minuta = 442,
        
        [EnumMember]
        Referatpropunerepromovarerecursinanularedosar = 443,
        
        [EnumMember]
        incheieredestramutare = 444,
        
        [EnumMember]
        incheieredeamanare = 445,
        
        [EnumMember]
        Recursinanularepromovatlacerereapartilor = 446,
        
        [EnumMember]
        Recursininteresullegii = 447,
        
        [EnumMember]
        DelegatiiindosareleincareMinisterulPublicesteparte = 448,
        
        [EnumMember]
        Conflictedecompetenta = 449,
        
        [EnumMember]
        Informariprivindcauzeimportanteaflateperolulinstantelor = 450,
        
        [EnumMember]
        FisagardaFinanciara = 451,
        
        [EnumMember]
        ComunicareahotararilorcivileprivindLegeanr5502002 = 452,
        
        [EnumMember]
        ComunicareahotararilorcivileprivindOUG1902000 = 453,
        
        [EnumMember]
        Referatcupropuneredeterminareaurmaririipenale = 454,
        
        [EnumMember]
        Referatcupropuneredescoateredesuburmarirepenala = 455,
        
        [EnumMember]
        Referatcupropuneredescoateredesuburmarirepenalacuaplicareauneiamenzicucaracteradministrativ181Cp = 456,
        
        [EnumMember]
        Referatcupropuneredeincetareaurmaririipenale = 457,
        
        [EnumMember]
        Referatcupropuneredeclasareacauzei = 458,
        
        [EnumMember]
        Referatcupropuneredeneincepereaurmaririipenale = 459,
        
        [EnumMember]
        Referatcupropuneredeconexare = 460,
        
        [EnumMember]
        Referatcupropunerededeclinareacompetentei = 461,
        
        [EnumMember]
        Adresasesizarecomandant = 462,
        
        [EnumMember]
        Motivederecurs2 = 463,
        
        [EnumMember]
        Cereredeamanare = 464,
        
        [EnumMember]
        Cerereamanare = 465,
        
        [EnumMember]
        acordaretermenpentrulipsadeaparare = 466,
        
        [EnumMember]
        Precizari = 467,
        
        [EnumMember]
        CopieminutadeciziedelaCSJ = 468,
        
        [EnumMember]
        Motivedeapel = 469,
        
        [EnumMember]
        Cerereinurgentareredactarehotarare = 470,
        
        [EnumMember]
        Confirmaretitluexecutoriu = 471,
        
        [EnumMember]
        Confirmaredebit = 472,
        
        [EnumMember]
        Mandatdetransfer = 473,
        
        [EnumMember]
        Cererederetragereaapeluluirecursului = 474,
        
        [EnumMember]
        Extrascertificatdedeces = 475,
        
        [EnumMember]
        DeclaratierecursainculpatuluipartiivatamatepartiicivilepartiiresponsabilecivilmenteParchetului = 476,
        
        [EnumMember]
        Declaratierecursainculpatului = 477,
        
        [EnumMember]
        Copiaminuteidecizieipenale = 478,
        
        [EnumMember]
        Dovadadeindeplinireaproceduriidecomunicare = 479,
        
        [EnumMember]
        Adresapentrudareindebitlaadministartiafinantelorpublice = 480,
        
        [EnumMember]
        Adresaderaspunsaadministartieifinantelorpublicepepreluareadebitului = 481,
        
        [EnumMember]
        Cererecomunicarehotararealteacte = 482,
        
        [EnumMember]
        Cererederenuntarelajudecata = 483,
        
        [EnumMember]
        Adresacomunicarerelatii = 484,
        
        [EnumMember]
        Cererejudecareinlipsa = 485,
        
        [EnumMember]
        Anexa = 486,
        
        [EnumMember]
        Copieminutaincheiere = 487,
        
        [EnumMember]
        Procesverbal = 488,
        
        [EnumMember]
        Comunicaredeciziepenalaincheiere = 489,
        
        [EnumMember]
        Cereredeamanarelaadouastrigare = 490,
        
        [EnumMember]
        Cereredeincuviintareaexecutariisilite = 491,
        
        [EnumMember]
        OficiulRegistruluiComertuluidepelangaTribunalulCluj = 492,
        
        [EnumMember]
        Referatcupropuneripromovarerecursininteresullegii = 493,
        
        [EnumMember]
        Referatcupropuneripromovarerecursinanulare = 494,
        
        [EnumMember]
        OrdinalProcuroruluiGeneral = 495,
        
        [EnumMember]
        Motivedeapel2 = 496,
        
        [EnumMember]
        Motivederecurs3 = 497,
        
        [EnumMember]
        Referatdeachitare = 498,
        
        [EnumMember]
        Referatderestituire = 499,
        
        [EnumMember]
        Raport = 500,
        
        [EnumMember]
        Adresa = 501,
        
        [EnumMember]
        Alteevidente = 502,
        
        [EnumMember]
        Documentatie = 503,
        
        [EnumMember]
        Inventar = 504,
        
        [EnumMember]
        Adeverinta = 505,
        
        [EnumMember]
        Analiza = 506,
        
        [EnumMember]
        Tematica = 507,
        
        [EnumMember]
        Situatie = 508,
        
        [EnumMember]
        Delegatie = 509,
        
        [EnumMember]
        Referatdearestarecunetrimitereinjudecata = 510,
        
        [EnumMember]
        Cereredeaudienta = 511,
        
        [EnumMember]
        Delegatie2 = 512,
        
        [EnumMember]
        Recursinanulare = 513,
        
        [EnumMember]
        Procesverbaldeindeplinireaproceduriideinmanareaunoracte = 514,
        
        [EnumMember]
        Planificare = 515,
        
        [EnumMember]
        Procesverbaldeconstataredepistare = 516,
        
        [EnumMember]
        Cereredeinregistraretardivaadecesului = 517,
        
        [EnumMember]
        Dovadadeinregistraretardivaadecesului = 518,
        
        [EnumMember]
        Regulatordecompetenta = 519,
        
        [EnumMember]
        DecizieainalteiCurtideCasatiesiJustitie = 520,
        
        [EnumMember]
        Notadestudiu = 521,
        
        [EnumMember]
        Cereredeincadrare = 522,
        
        [EnumMember]
        Cererederecalcularedrepturibanesti = 523,
        
        [EnumMember]
        Cereredeconcediu = 524,
        
        [EnumMember]
        Cereredeconcediupentrucresterecopil = 525,
        
        [EnumMember]
        Cerereeliberarelegitimatiedeserviciu = 526,
        
        [EnumMember]
        Cereredetreceredelaosectielaalta = 527,
        
        [EnumMember]
        Cereredereluareaactivitatiidupaconcediupentrucresterecopil = 528,
        
        [EnumMember]
        Cereredetransfer = 529,
        
        [EnumMember]
        Cereredenumire = 530,
        
        [EnumMember]
        Cererededecontaremedicamente = 531,
        
        [EnumMember]
        Cererededecontaretransport = 532,
        
        [EnumMember]
        Cererededelegare = 533,
        
        [EnumMember]
        Cererededetasare = 534,
        
        [EnumMember]
        Cereredepromovare = 535,
        
        [EnumMember]
        Cereredeeliberareadeverinta = 536,
        
        [EnumMember]
        Cereredeeliberaredinfunctie = 537,
        
        [EnumMember]
        Cereredepensionare = 538,
        
        [EnumMember]
        Informareeveniment = 539,
        
        [EnumMember]
        Concluziiscrise = 540,
        
        [EnumMember]
        Cereredelasarelaurmasedintei = 541,
        
        [EnumMember]
        Cereredesolicitarecertificat = 542,
        
        [EnumMember]
        Obiectiunilaraportdeexpertiza = 543,
        
        [EnumMember]
        Cereredenedeclararerecursimpotrivaincheieriidecizieipenale = 544,
        
        [EnumMember]
        Restituirenotegrefierdesedinta = 545,
        
        [EnumMember]
        Cereredeneconstituirepartecivila = 546,
        
        [EnumMember]
        Cereredeconstituirepartecivila = 547,
        
        [EnumMember]
        Cererereferitoarelacauzaincursdejudecata = 548,
        
        [EnumMember]
        Cereredeasistentajudiciarainternationala = 549,
        
        [EnumMember]
        DecizieaCurtiiConstitutionale = 550,
        
        [EnumMember]
        Cereredeplataoresuplimentare = 551,
        
        [EnumMember]
        Optiuneinurmaexamenuluidecapacitate = 552,
        
        [EnumMember]
        Adresadetrimiterememoriuplangere = 553,
        
        [EnumMember]
        Adresacupropuneredeanusedeclararecurs = 554,
        
        [EnumMember]
        Ordonantadestabilireacompetentei = 555,
        
        [EnumMember]
        Rezolutiedeconfirmare = 556,
        
        [EnumMember]
        Cererepentrusolutionareaconflictuluinegativdecompetenta = 557,
        
        [EnumMember]
        Comunicareahotararilorcivileprivindsolutionareacererilordeindreptareaeroriimateriale = 558,
        
        [EnumMember]
        Situatieprivindcauzeleavandobiectdreptuldeproprietateintelectuala = 559,
        
        [EnumMember]
        Copiaminuteisentinteipenale = 560,
        
        [EnumMember]
        Cereredeinvestire = 561,
        
        [EnumMember]
        Mandatdeexecutareapedepseiinchisorii = 562,
        
        [EnumMember]
        Comunicareextras = 563,
        
        [EnumMember]
        Comunicaretitlucatredebitor = 564,
        
        [EnumMember]
        Dovadacomunicariicatredebitor = 565,
        
        [EnumMember]
        Comunicaretitlucatreorganuldeexecutare = 566,
        
        [EnumMember]
        Cerere = 567,
        
        [EnumMember]
        Invitatie = 568,
        
        [EnumMember]
        Reclamatie = 569,
        
        [EnumMember]
        Petitie = 570,
        
        [EnumMember]
        instiintare = 571,
        
        [EnumMember]
        Documentatiedespecialitate = 572,
        
        [EnumMember]
        Carte = 573,
        
        [EnumMember]
        Revista = 574,
        
        [EnumMember]
        Oferta = 575,
        
        [EnumMember]
        Felicitare = 576,
        
        [EnumMember]
        Dovadadepunerecautiune = 577,
        
        [EnumMember]
        Cerereintroductivapentrudeaschidereaproceduriiinsolventeilacerereacreditorului = 578,
        
        [EnumMember]
        Certificat2 = 579,
        
        [EnumMember]
        Renuntarelacaleadeatac = 580,
        
        [EnumMember]
        Cerereadefixareaunuitermendeurgenta = 581,
        
        [EnumMember]
        Interogatoriu = 582,
        
        [EnumMember]
        Documenteindosar = 583,
        
        [EnumMember]
        cereredesesizareaCurtiiConstitutionale = 584,
        
        [EnumMember]
        propuneredearestarepreventiva = 585,
        
        [EnumMember]
        cererededobandireapersonalitatiijuridice = 586,
        
        [EnumMember]
        incheieredeamanareajudecarii = 587,
        
        [EnumMember]
        incheieredeexecutaresilita = 588,
        
        [EnumMember]
        incheieresesizareCJUE = 589,
        
        [EnumMember]
        CererecontestatieNCPP = 590,
        
        [EnumMember]
        Opinieseparata = 591,
        
        [EnumMember]
        Hotarareintermediara = 592,
        
        [EnumMember]
        Adresacomunicareraportasuprachestiuniidedreptsupusejudecatii = 593,
        
        [EnumMember]
        Acordulderecunoastereavinovatiei = 594,
        
        [EnumMember]
        RaportproceduradefiltruNCPP = 595,
        
        [EnumMember]
        Incheiereproceduradefiltru = 596,
        
        [EnumMember]
        Buletinstatisticpentrudivort = 597,
        
        [EnumMember]
        Fisacriminologicaavictimei = 598,
        
        [EnumMember]
        Fisainculpatului = 599,
        
        [EnumMember]
        Rezolutieprimireacereriidechemareinjudecata = 600,
        
        [EnumMember]
        AdresalaEvidentaPersoaneipentrucomunicaredomiciliuresedinta = 601,
        
        [EnumMember]
        AdresaRegistrulCometuluipentrucomunicaresediu = 602,
        
        [EnumMember]
        AdresaBirouNotarialpentrucertificatdemostenitor = 603,
        
        [EnumMember]
        AdresaCameraNotarilorpentruverificaredeschideresuccesiune = 604,
        
        [EnumMember]
        AdresEvidentaPersoaneipentrucomunicareCNP = 605,
        
        [EnumMember]
        Asigurareprezentaminor = 606,
        
        [EnumMember]
        AdresaDGASPCpentruraportevaluare = 607,
        
        [EnumMember]
        AdresaAutoritatetutelarapentruanchetasociala = 608,
        
        [EnumMember]
        Adresapentruveniturinete = 609,
        
        [EnumMember]
        AdresaAFPpentruvenituricastigurinete = 610,
        
        [EnumMember]
        AdresaAFPpentrubilantcontabil = 611,
        
        [EnumMember]
        ProcesverbalascultareminorL2722004 = 612,
        
        [EnumMember]
        ProcesverbalascultareminorCFam = 613,
        
        [EnumMember]
        Incheieredeinfiintarepoprire = 614,
        
        [EnumMember]
        Adresapentrucomunicarepoprire = 615,
        
        [EnumMember]
        Adresapentruactecareaustatlabazaemiteriiautorizatieideconstruire = 616,
        
        [EnumMember]
        Adresapentruactecareaustatlabazaemiteriititluluideproprietate = 617,
        
        [EnumMember]
        Adresapentrucomunicaresituatiejuridica = 618,
        
        [EnumMember]
        Adresapentruistoricadresaimobil = 619,
        
        [EnumMember]
        Adresapentruistoricrolfiscal = 620,
        
        [EnumMember]
        Adresapentruactecareaustatlabazaemiteriidispozitiei = 621,
        
        [EnumMember]
        Adresapentrucopiecontractdeinchiriere = 622,
        
        [EnumMember]
        AdresapentruinscrisuricareaustatlabazainscrieriiinCFindividuala = 623,
        
        [EnumMember]
        Adresapentrucomunicaresolutionarelitigiu = 624,
        
        [EnumMember]
        AdresapentrucopieCFcolectiva = 625,
        
        [EnumMember]
        Adresapentrunotarelitigiuactjuridicincheiatlanotar = 626,
        
        [EnumMember]
        Adresapentrunotarelitigiuactjuridictitludeproprietate = 627,
        
        [EnumMember]
        Adresapentruinscrieresechestru = 628,
        
        [EnumMember]
        Adresapentruradieresechestru = 629,
        
        [EnumMember]
        Adresapentrucomunicarehotarareconstatarenulitate = 630,
        
        [EnumMember]
        Adresaprivindsolutionareacaiideatacimpotrivaincheieriijudecatoruluidelegat = 631,
        
        [EnumMember]
        AdresaDGFPpentrucomunicaredizolvare = 632,
        
        [EnumMember]
        Adresaexpertpentruefectuareexpertiza = 633,
        
        [EnumMember]
        AdresaIMLpentruexpertiza = 634,
        
        [EnumMember]
        AdresaANPCpentruexpertiza = 635,
        
        [EnumMember]
        Adresaexpertpentrusuplimentexpertiza = 636,
        
        [EnumMember]
        Adresaexpertpentruexpertizanoua = 637,
        
        [EnumMember]
        Adresaexpertpentruraspunslaobiectiuni = 638,
        
        [EnumMember]
        AdresaBLETpentrucomunicarenumireexpert = 639,
        
        [EnumMember]
        AdresacatreCameradevaloriainstantei = 640,
        
        [EnumMember]
        AdresacatreINS = 641,
        
        [EnumMember]
        Adresapentrudovadacomunicareprocesverbaldecontraventie = 642,
        
        [EnumMember]
        Adresapentrudateinmatriculareautovehicol = 643,
        
        [EnumMember]
        Adresadeclinare = 644,
        
        [EnumMember]
        Adresatrimiteredosarincaleadeatac = 645,
        
        [EnumMember]
        Adresarestituiredosardincaleadeatac = 646,
        
        [EnumMember]
        Adresarestituiredosardupaefectuareacomisieirogatorii = 647,
        
        [EnumMember]
        AdresaAFPpentrucomunicaretitluexecutoriuamendajudiciara = 648,
        
        [EnumMember]
        AdresaAFPpentrucomunicareadmiterecereredereexaminare = 649,
        
        [EnumMember]
        Mandatuldearestarepreventiva = 650,
        
        [EnumMember]
        Procesverbaldeincunostintaredespreluareamasuriiarestariipreventive = 651,
        
        [EnumMember]
        Procesverbalcareconsemneazadeclarareanedeclararearecursuluiinsedintapublica = 652,
        
        [EnumMember]
        Adresaincazulprelungiriiarestariipreventive = 653,
        
        [EnumMember]
        Adresaincazulinlocuiriimasuriiarestariipreventivecumasuraobligariideanuparasitaracomunicarelapolitie = 654,
        
        [EnumMember]
        Adresainlocuireaarestariipreventivecuobligatiadeanuparasitaracomunicarelapolitiadefrontiera = 655,
        
        [EnumMember]
        AdresainlocuireaarestariipreventivecumasuraobligariideanuparasitaracomunicarelaServiciulPasapoarte = 656,
        
        [EnumMember]
        Adresaincazulincetariidedreptamasuriiarestariipreventive = 657,
        
        [EnumMember]
        AdresaincazulprelungiriimasuriiobligariideanuparasilocalitateataracomunicarelaPolitie = 658,
        
        [EnumMember]
        AdresaincazulprelungiriimasuriiobligariideanuparasitaracomunicarePolitiadefrontiera = 659,
        
        [EnumMember]
        AdresaincazulprelungiriimasuriiobligariideanuparasitaracomunicareServiciulpasapoarte = 660,
        
        [EnumMember]
        Autorizatiadeperchezitiecontinut = 661,
        
        [EnumMember]
        Adresapentruaflareadomiciliului = 662,
        
        [EnumMember]
        Adresapentruaflareasediuluiuneisocietaticomerciale = 663,
        
        [EnumMember]
        AdresalANPpentrutransferareaunuidetinutaflatintrunaltpenitenciar = 664,
        
        [EnumMember]
        Dispozitiepentrutransferareaunuidetinutaflatintrunaltpenitenciar = 665,
        
        [EnumMember]
        AdresaANPpentruaverificadacauninculpatestearestatintrunpenitenciar = 666,
        
        [EnumMember]
        Adresapentruaverificainregistrareadecesuluiuneiparti = 667,
        
        [EnumMember]
        Adresapentruaverificainregistrareadeschideriisuccesiuniiuneiparti = 668,
        
        [EnumMember]
        Adresapentruaflareamosenitoriloruneiparti = 669,
        
        [EnumMember]
        Mandatuldearestarepreventivamasuraluataincursuljudecatii = 670,
        
        [EnumMember]
        Mandatuldearestarepreventivamasuraluataprinhotarareadecondamnare = 671,
        
        [EnumMember]
        Adresaincazulmentineriiarestariipreventiveincursuljudecatii = 672,
        
        [EnumMember]
        Adresaincazulrevocariiarestariipreventiveincursuljudecatii = 673,
        
        [EnumMember]
        Adresaincazulmentineriiarestariipreventivelaprimireadosarului = 674,
        
        [EnumMember]
        Adresaincazulrevocariiarestariipreventivelaprimireadosarului = 675,
        
        [EnumMember]
        Adresainlocuireaarestariipreventivecuobligatiadeanuparasilocalitateataracomunicarelaloculdedetinere = 676,
        
        [EnumMember]
        Adresaincazulrevocariimasuriiarestariipreventive = 677,
        
        [EnumMember]
        Adresaincazulluariimasuriiobligariideanuparasilocalitateataracomunicarelapolitie = 678,
        
        [EnumMember]
        Adresaincazulluariimasuriiobligariideanuparasitaracomunicarelapolitiadefrontiera = 679,
        
        [EnumMember]
        AdresaincazulluariimasuriiobligariideanuparasitaracomunicareServiciulPasapoarte = 680,
        
        [EnumMember]
        Desemnareaunuiavocatdinoficiue = 681,
        
        [EnumMember]
        Efectuareauneiexpertizedecatreoinstitutie = 682,
        
        [EnumMember]
        Efectuareauneiexpertizedecatreunexpertdesemnatdeinstanta = 683,
        
        [EnumMember]
        Obtinereafiseidecazierjudiciar = 684,
        
        [EnumMember]
        Solicitareauneihotararipronuntatadeoaltainstanta = 685,
        
        [EnumMember]
        Solicitareaunuidosaralalteiinstanteunuiparchet = 686,
        
        [EnumMember]
        Restituireaunuidosaral_alteiinstanteunuiparchet = 687,
        
        [EnumMember]
        Inaintareadosaruluiinvedereasolutionariicereriiderecuzareaintregiiinstante = 688,
        
        [EnumMember]
        EfectuareaunuireferatdeevaluaredecatreServiciuldeprotectieavictimelorsireintegraresocialaainfractorilor = 689,
        
        [EnumMember]
        Inaintareaunuidosarlasolicitareaalteiinstanteunuiparchet = 690,
        
        [EnumMember]
        Inaintareaunuidosarinstanteideapelinvedereasolutionariicaiideatac = 691,
        
        [EnumMember]
        Inaintareaunuidosarinstanteiderecursinvedereasolutionariicaiideatac = 692,
        
        [EnumMember]
        Restituireaunuidosardecatreinstantadecontroljudiciardupasolutionareacaiideatac = 693,
        
        [EnumMember]
        AdresadeinaintareamandatuluilaPolitieinvedereapuneriiinexecutare = 694,
        
        [EnumMember]
        Mandatuldeexecutareapedepseiinchisoriirevenire = 695,
        
        [EnumMember]
        InterzicereaunordrepturicomunicareCentrumilitar = 696,
        
        [EnumMember]
        Masuridesigurantacucaractermedicalinternare = 697,
        
        [EnumMember]
        Masuridesigurantacucaractermedicalobligarelatratament = 698,
        
        [EnumMember]
        Adresapentruevidentaamanarilorsisauintreruperilorexecutariipedepsei = 699,
        
        [EnumMember]
        Comunicaricatreinstantadeexecutaresentintapenala = 700,
        
        [EnumMember]
        Comunicaricatreinstantadeexecutareextrasdeciziepenala = 701,
        
        [EnumMember]
        RaportpentrurecursulininteresullegiiRIL = 702,
        
        [EnumMember]
        ComunicareaextrasuluidepetitlulexecutoriuCheltuielijudiciare = 703,
        
        [EnumMember]
        PunereainexecutareacheltuielilorjudiciareamenzilorconfiscariispecialeAdresapentruaflareaCNPdebitori = 704,
        
        [EnumMember]
        PunereainexecutareamasuriieducativeainternariiincentrudereeducarecomunicarePolitie = 705,
        
        [EnumMember]
        adresaANPcomunicaretermen = 706,
        
        [EnumMember]
        adresaANPtrimiterecitatie = 707,
        
        [EnumMember]
        adresaConsiliullocalcomunicaretermen = 708,
        
        [EnumMember]
        Adresaexpedierecopiedecizie = 709,
        
        [EnumMember]
        adresainterpret = 710,
        
        [EnumMember]
        adresamotiverecurs = 711,
        
        [EnumMember]
        AdresaPenitenciarcomunicaretermen = 712,
        
        [EnumMember]
        adresapenitenciarexpedierecopiedecizie = 713,
        
        [EnumMember]
        AdresaPolitietrimiterecitatie = 714,
        
        [EnumMember]
        adresarevenireSP = 715,
        
        [EnumMember]
        adresastramutare = 716,
        
        [EnumMember]
        adresatrimiteredosar = 717,
        
        [EnumMember]
        Baroucerereaparatorioficiu = 718,
        
        [EnumMember]
        Baroucomunicareonorariu = 719,
        
        [EnumMember]
        Baroucomunicaretermen = 720,
        
        [EnumMember]
        formulardeciziecsj = 721,
        
        [EnumMember]
        formularminutacsj = 722,
        
        [EnumMember]
        Formularverifarestareprevent = 723,
        
        [EnumMember]
        instiintaremotiverecurs = 724,
        
        [EnumMember]
        SEadresacomunicaretermenjudecata = 725,
        
        [EnumMember]
        AdresatrimiteredosarSCA = 726,
        
        [EnumMember]
        Formularmandateuropeandearestare = 727,
        
        [EnumMember]
        Formularmandatinterceptare = 728,
        
        [EnumMember]
        Formularmandatperchezitie = 729,
        
        [EnumMember]
        Formularmandaturmarireeuropeana = 730,
        
        [EnumMember]
        Formularmandaturmarireinternationala = 731,
        
        [EnumMember]
        HOTaRaRE = 732,
        
        [EnumMember]
        incheiereRecurs = 733,
        
        [EnumMember]
        incheierePerchezitie2 = 734,
        
        [EnumMember]
        Mandatarestareincursuljudecatii = 735,
        
        [EnumMember]
        Document100019 = 736,
        
        [EnumMember]
        Document100061 = 737,
        
        [EnumMember]
        Document100010 = 738,
        
        [EnumMember]
        Document100119 = 739,
        
        [EnumMember]
        Document100014 = 740,
        
        [EnumMember]
        Document100003 = 741,
        
        [EnumMember]
        Document100038 = 742,
        
        [EnumMember]
        Document100046 = 743,
        
        [EnumMember]
        Document100016 = 744,
        
        [EnumMember]
        Document100044 = 745,
        
        [EnumMember]
        Document100117 = 746,
        
        [EnumMember]
        Document100157 = 747,
        
        [EnumMember]
        Document100244 = 748,
        
        [EnumMember]
        Document100065 = 749,
        
        [EnumMember]
        Document100076 = 750,
        
        [EnumMember]
        Document100063 = 751,
        
        [EnumMember]
        Document100015 = 752,
        
        [EnumMember]
        Document100053 = 753,
        
        [EnumMember]
        Document11008 = 754,
        
        [EnumMember]
        Document100182 = 755,
        
        [EnumMember]
        Document100072 = 756,
        
        [EnumMember]
        Document100031 = 757,
        
        [EnumMember]
        Document100027 = 758,
        
        [EnumMember]
        Document100042 = 759,
        
        [EnumMember]
        Document100085 = 760,
        
        [EnumMember]
        Document100080 = 761,
        
        [EnumMember]
        Document100041 = 762,
        
        [EnumMember]
        Document100172 = 763,
        
        [EnumMember]
        Document100079 = 764,
        
        [EnumMember]
        Document100028 = 765,
        
        [EnumMember]
        Document100005 = 766,
        
        [EnumMember]
        Document100017 = 767,
        
        [EnumMember]
        Document100156 = 768,
        
        [EnumMember]
        Document100081 = 769,
        
        [EnumMember]
        Document100089 = 770,
        
        [EnumMember]
        Document100068 = 771,
        
        [EnumMember]
        Document100012 = 772,
        
        [EnumMember]
        Document100030 = 773,
        
        [EnumMember]
        Document100057 = 774,
        
        [EnumMember]
        Document100047 = 775,
        
        [EnumMember]
        Document100161 = 776,
        
        [EnumMember]
        Document100002 = 777,
        
        [EnumMember]
        Document100058 = 778,
        
        [EnumMember]
        Document100060 = 779,
        
        [EnumMember]
        Document100021 = 780,
        
        [EnumMember]
        Document100102 = 781,
        
        [EnumMember]
        Document100008 = 782,
        
        [EnumMember]
        Document100020 = 783,
        
        [EnumMember]
        Document100007 = 784,
        
        [EnumMember]
        Document100011 = 785,
        
        [EnumMember]
        Document100043 = 786,
        
        [EnumMember]
        Document100025 = 787,
        
        [EnumMember]
        Document100213 = 788,
        
        [EnumMember]
        Document100106 = 789,
        
        [EnumMember]
        Document100024 = 790,
        
        [EnumMember]
        Document100023 = 791,
        
        [EnumMember]
        Document100155 = 792,
        
        [EnumMember]
        Document100036 = 793,
        
        [EnumMember]
        Document100073 = 794,
        
        [EnumMember]
        Document100055 = 795,
        
        [EnumMember]
        Document100040 = 796,
        
        [EnumMember]
        Document100078 = 797,
        
        [EnumMember]
        Document100049 = 798,
        
        [EnumMember]
        Document100026 = 799,
        
        [EnumMember]
        Document100104 = 800,
        
        [EnumMember]
        Document100004 = 801,
        
        [EnumMember]
        Document100056 = 802,
        
        [EnumMember]
        Document100045 = 803,
        
        [EnumMember]
        Document100115 = 804,
        
        [EnumMember]
        Document100032 = 805,
        
        [EnumMember]
        Document100022 = 806,
        
        [EnumMember]
        Document100006 = 807,
        
        [EnumMember]
        Document100062 = 808,
        
        [EnumMember]
        Document100082 = 809,
        
        [EnumMember]
        Document100001 = 810,
        
        [EnumMember]
        Document100009 = 811,
        
        [EnumMember]
        Document100013 = 812,
        
        [EnumMember]
        Document100050 = 813,
    }
}