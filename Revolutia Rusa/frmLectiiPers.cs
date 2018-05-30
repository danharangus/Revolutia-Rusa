using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revolutia_Rusa
{
    public partial class frmLectiiPers : Form
    {
        int c = 1;

        public frmLectiiPers()
        {
            InitializeComponent();
        }

        private void frmLectiiPers_Load(object sender, EventArgs e)
        {
            if (variabile.Personalitatea == "Lenin")
            {
                lblLectiiPers.Text = "Vladimir Ilici Lenin";
                textBox1.Text = "          În 22  aprilie, in 1870 la la Simbirsk, langa fluviul Volga, Rusia, s-a nascut Vladimir Ilici Lenin. A devenit un simbol universal al ideologiei comuniste, inspirand miscarile revolutionare din toata lumea. Vladimir Ilici Ulianov s-a nascut intr-o familie din clasa privilegiata, in Rusia secolului al nouasprezecelea. Tatal sau, Ilia, inspector al scolilor elementare, era casatorit cu Maria Alexandrovna, fiica unui medic evreu, bogat. Lenin a fost unul dintre cei sase copii ai lor; În 1887 In luna mai, fratele sau, Alexandr, a fost arestat si spanzurat pentru ca a complotat in vederea asasinarii țarului Alexandru - un eveniment ce l-a impins pe Lenin pe drumul revoluției. Lenin s-a inscris la Universitatea din Kazan in același an, dar a fost exmatriculat pentru activități ilegale de opoziție și exilat pe moșia bunicului său, in satul Kokuskino. Acolo, in exil, a inceput să-i citească pe scriitorii revoluționari europeni, mai ales pe Karl Marx, si a devenit un marxist autodidact. Dupa ce și-a luat diploma de avocat, s-a mutat la St. Petersburg, unde s-a alăturat mișcarii ilegaliste care lupta impotriva regimului țarist.\r\n          Lenin a ajutat la fondarea organizației marxiste a muncitorilor din St. Petersburg, fapt pentru care a fost arestat pentru cincisprezece luni, intr-un exil de trei ani in Siberia.\r\n          A fost exilat din nou in Siberia in 1899.Eliberat, a fugit in străinatate unde a fondat, impreună cu alti revoluționari, ziarul Iskra (Scanteia În 1902 a publicat celebra sa carte, ,,Ce e de făcut?''. Lenin a ajuns să creadă ca revoluția nu putea saăaiba sorți de izbandă, decăt dacă era condusă de un mic grup profesionist - de fapt, controlată de la vărf. Insistența cu care susținea formarea unor cadre revoluționare profesioniste a fragmentat principalul grup de opozitie - Partidul Social Democrat al Muncii din Rusia.\r\n          La congresul partidului, care s-a tinut la Londra, s-au conturat cele doua factiuni - mensevicii (minoritarii, in ruseste), care i se opuneu lui Lenin si bolșevicii (majoritarii, in ruseste), care il sustineau cu o majoritate destul de redusă.\r\n          Cănd  a izbucnit I prima revolutie rusă , in 1905,Lenin era in străinatate dar s-a intors acasă, A plecat din nou in exil cănd au inceput măsurile represive. Menșevicii si bolșevicii s-au acuzat reciproc de esecul revolutiei si s-au despărtit irevocabil in 1912. In acest timp, Lenin suferea in exil. A continuat să scrie, reusind sa termine ,,Materialism si empiriocritism'', in 1909.\r\n          La izbucnirea  Primuuil Război Mondial, i-a chemat pe muncitori să se unească si să impiedice ca ,,un razboi imperialist sa se transforme in razboi civil''. Datoria lor, era sa distruga capitalismul, nu sa se lupte intre ei.\r\n          Lenin nu se afla in Rusia, din februarie, cand a fost răsturnat regimul țarist; a ajuns inapoi in Rusia prin Germania, o lună mai tarziu, intr-un tren inchis. Rusia era condusă de un guvern provizoriu, slab, format din burghezi, in fruntea caruia era Alexandr Kerenski. Armata rusa inca lupta in razboi. Lenin a intuit momentul favorabil si a chemat la revolutie; la congresul convocat de urgenta, partidul bolșevic a lansat sloganul ,,Toată puterea sovietelor''.  In iulie, revolta muncitorilor a dat gres, iar Lenin si-a petrecut lunile august si septembrie in Finlanda, susșinăndu-si opinia că trebuia sa se organizeze o insurectie armata in capitala. Pana la urma, aceasta a izbucnit la 25 octombrie - faimoasa ,,Revoluție din Octombrie'' - si, cateva zile mai tarziu, Lenin era ales conducator al comisarilor poporului - de fapt, șef al guvernului. Treptat, cu multa precautie, Lenin a consolidat puterea noului stat sovietic.  A incheiat razboiul cu Germania, acceptănd niște termeni inrobitori si a inceput sa implementeze ceea ce pana atunci nu existase decat pe hartie - un stat politic. A inceput cu improprietarirea maselor nemultumite de tarani, care dusesera greul razboiului si cu un decret de nationalizare a industriei. Cu toate acestea, lucrul care-l preocupa cel mai mult pe Lenin era cum sa ramana la putere, deoarece tanarul stat sovietic s-a confruntat, mai intai, cu un razboi civil brutal, desfasurat intre 1918 si 1921, si apoi cu o foamete din cauza careia au murit milioane de oameni.\r\n          Bolsevicii devin Partidul Comunist, in 1918,incepe razboiul civil, familia tarista este executata.\r\n          După război, Lenin a trebuit sa recurgă la compromisuri pentru a asigura supravietuirea comunismului si a elaborat Noua Politica Economica, care era menita sa restabileasca intr-o anumita masura economica de piata. /r/n          In mai1922 Lenin a suferit primul dintre cele trei atacuri cerebrale si din aceasta cauza a pierdut controlul direct al guvernului.\r\n          1924 La 21 ianuarie, Vladimir Lenin moare, la Gorki, Rusia. Un strateg genial, nu a trait indeajuns de mult pentru a-si vedea visul transformat in cosmar de succesorul sau, Iosif Stalin. Lenin spunea candva: ,,Pace, păine, pămănt si putere pentru soviete !'' ";
            }
            else if (variabile.Personalitatea == "Nicolae")
            {
                lblLectiiPers.Text = "Nicolae al II-lea";
                textBox1.Text = "          Țarul Nicolae al II-lea al Rusiei sau Nikolai Alexandrovici Romanov a fost ultimul imparat al Rusiei. A domnit din 1894 până la abdicarea sa din 15 martie 1917 la sfârșitul revoluției din februarie.A fost asasinat împreună cu întreaga sa familie de către bolșevici la ordinul lui Lenin. A fost canonizat drept sfânt al bisericii ortodoxe ruse.\r\n          Nicolae s-a suit pe tron pe 1 noiembrie 1894, și la scurtă vreme după aceea s-a căsătorit cu Prințesa Alix (din acel moment înainte Împărăteasa Alexandra Feodorovna). Ei au avut cinci copii: Marile Ducese Olga, Tatiana, Maria, Anastasia și Țareviciul Alexei. Titlul de Țar, derivat din titlul roman Cezar, ajuns în rusă prin bizantinul Kaisar, a fost abolit oficial în 1712 de Petru cel Mare, dar a fost folosit în mod neoficial de-a lungul domniei lui Nicolae.\r\n          Înăsprirea condițiilor de viață din spatele frontului și incapacitatea armatei de a menține succesele militare temporare din iunie 1916 au dus la o serie de noi greve și tulburări în iarna care a urmat. La sfârșitul „Revoluției din februarie” din 2 martie (stil vechi)/ 15 martie (stil nou) 1917 Nicolae al II-lea a fost forțat să abdice în numele său și al țareviciului, în favoarea fratelui lui, spunând: „Lasăm moștenire succesiunea noastră fratelui nostru, Marele Duce Mihail Alexandrovici, și îi dăm binecuvântarea noastră la urcarea pe tron.”  Marele Duce Mihail a refuzat să accepte tronul și a abdicat a doua zi, și astfel trei secole de istorie a dinastiei Romanov s-au încheiat.\r\n          Familia Romanov și toți cei care au ales să-i însoțească în captivitate au fost împușcați, înjunghiați cu baionetele și omorâți cu lovituri la Ekaterinburg în noaptea de 16–17 iulie 1918. Țarul și familia sa au fost uciși de trupe bolșevice conduse de Iakov Iurovski din ordinele Sovietului Regional Ural și conform instrucțiunilor lui Lenin, Iakov Sverdlov and Felix Dzerjinski. Trupurile lor au fost apoi dezbrăcate, mutilate, arse și îngropate pe un câmp numit Porosenkov Logîn pădurea Kopteaki.";
            }
            else if (variabile.Personalitatea == "Stalin")
            {
                lblLectiiPers.Text = "Iosif Stalin";
                textBox1.Text = "          (1879-1953),secretar general al partidului Comunist din Uniunea Republicilor Sovietice (URSS)din 1922 in 1953, a fost un  conducător  care mai mult ca orice individ a modelat trăsăturile ce caracterizau regimul sovietic.\r\n          Stalin s-a nascut sub numele de Iosif Vissarionovich Dzhugashvili in orasul Gori, Georgia, care la acea vreme era parte integrantă a Imperiului Rus. El al treilea si singurul copil supravietuitor a unui ciubotar si a unei casnice. In 1888 Stalin a inceput cursurile la scoala bisericii din Gori, unde a invațat rusa si a fost un elev remarcabil, si a căstigat o bursă la Seminarul Teologic din T’bilisi in 1894.\r\n          Stalin și-a inceput studiile la seminar ortodox. El a fost curănd expus ideilor radicale ale colegilor săi si a inceput să citeasca carti interzise bazate pe opera germanului Karl Marx. In 1899 inainte de a absolvi a  renunță la educația religioasă si este absorbit de mișcarea revolușionara rusă anti - monarhică. In timp ce lucra ca contabil in Tbilisi, Stalin răspandea propaganda  marxistp in interesul organizatiei Social Democratice locale printre lucraăori feroviar. Dupa ce se muta lin portul Bat’umi, unde organizeaza miscari de protest in 1902, Stalin este urmarit si arestat de poliția imperială. Un an mai tărziu este exilat in Siberia. Reuseste să evadeze si revine in Georgia in 1904.\r\n          S-a alăturat miscarii marxiste ilegale, iar n 1903, cind partidul s-a scindat, el s-a situat de partea aripii bolsevice, in ierioada care a urmat păna la 1917, a fost membru activ al partidului, fiind restat de cel putin sase ori. În această perioada a adoptat pseudonimul - Stalin (Omul de oțel).\r\n          Stalin nu a jucat un rol important in timpul revolutiei comuniste din 917. Totuși, el a fost foarte activ in următorii doi ani, iar in 1922 a evenit secretar general al Partidului Comunist. Acest post i-a conferit o influență in aparatul de partid si a constituit un atu important in lupta pentru putere care a izbucnit dupa moartea lui Lenin.A reușit să ajungă la conducere prin înlăturarea opozanților.\r\n          In 1930 Stalin prin politica sa incearca sa faca un front comun in E Europei anti-fascist dar renunta la idee in 1939 cand semnează o alianța cu germanii in august. Prin Pactul de neagresiune sovieticii si naziști imparteau Europa in doua sfere de influentț; sovieticii au permis Germaniei sa invadeze Polonia cu condiția ca nu se vor atinge de teritoriul rus. In ciuda avertismentelor, Stalin este luat prin surprindere de atacul german din iunie 1941 cand germanii lansează operatiunea „Barbarossa”. In urma luptelor pierdute germani se retrag si odata cu ei sovieticii pătrund in E Europei. Cu acordul Aliaților sovietici eliberează mai multe țări unde instaureaza regimuri comuniste lăsănd astfel „Cortina de fier” intre E si V Europei.\r\n          In 1950 Stalin era bolnav atat fizic cat si psihic si absenteaza mult de la lucrarile guvernului de la Kremlin. Subalternilor  lui Stalin le era frica sa nu cada victima  paranoiei crescande. In ianuarie 1953 Stalin ordona arestarea unor doctori din Kremlin pentru ca ar fi incercat uciderea oficialilor sovietici. Pe cănd un nou val de teroare părea iminent Stalin moare datorită unei congestii cerebrale ,in martie. ";

            }
            else if (variabile.Personalitatea == "Aleksandr Kerenski")
            {
                lblLectiiPers.Text = "Aleksandr Kerenski";
                textBox1.Text = "          Alexandr Fiodorovici Kerenski. 22 aprilie 1881 (S.N. 2 mai) - d. 11 iunie 1970) a fost al doilea prim-ministru al Guvernului provizoriu rus, chiar inainte ca bolsșevicii lui Lenin să cucerească puterea.\n\r          Kerenski s-a nascut in Simbirsk (azi Ulianovsk), ca fiul al unui director de scoala. Simbirsk este si locul de naștere al lui Lenin. Intamplarea face ca tatăl lui Kerenski, Feodor, să fi fost profesorul si directorul  luiVladimir Ilici Ulianov.\r\n          Alexandr Kerenski a primit licența in drept a Universitatii din Sankt Peterburg in 1904. Si-a arătat repede simpatiile politice atunci cănd a aparat revoluționarii antitariști. A fost ales membru al celei de-a patra Dume (parlament) in 1912 ca membru al Trudovicilor (un partid moderat liberal). Kerenski, a devenit membru al Comitetului Provizoriu al Dumei ca membru al Partidului Socialist Revoluționar si lider al opozantilor socialiști ai țarului Nicolae al II-lea.Cănd a izbucnit Revoluția din Februarie in 1917, Kerenski a fost unul dintre cei mai proeminenti lideri revoluționari si a fost ales vicepreședinte al Sovietului din Petrograd.Cănd a fost format Guvernul provizoriu rus, el a fost numit la inceput Ministru al Justiției, dar a devenit Ministru de Război in mai si Prim - ministru in iulie 1917.După tentativa eșuată de lovitură de stat a generalului Lavr Kornilov din august si după demisia miniștrilor, el s - a autoinvestit si in funcția de Comandant Suprem al armatei.\r\n          Pe durata tentativei de lovitură de stat a lui Kornilov, Kerenski a distribuit arme muncitorilor din Petrograd si, pănă in octombrie, majoritatea acestor muncitori inarmați trecuseră de partea bolșevicilor. Lenin era hotărat să răstoarne guvernul Kerenski mai inainte ca acesta să fie legitimizat de alegerile plănuite să se țină pentru Adunarea Constituantă Rusă si, pe 25 octombrie(stil vechi)/7 noiembrie (stil nou), bolșevicii au preluat puterea in ceea ce avea să devină cunoscut sub numele de Revoluția din Octombrie.\n\r          Kerenski a scăpat de urmărirea bolșevicilor si a fugit la Pskov, unde a concentrat trupe loiale guvernului provizoriu in incercarea de a recuceri capitala. Trupele lui au ocupat Tarskoe Selo, dar au fost invinse a doua zi la Pulkovo. Kerenski de-abia a scăpat din aceasta infrăngere si in următoarele căteva luni s-a ascuns pănă cănd a putut părăsi țara, ajungănd in cele din urmă in Franța. In timpul războiului civil rus, el nu a susținut nicio tabără – s-a opus atăt regimului bolșevic rosu cat si Mișcarii Albe a generalilor monarhiști.Kerenski a trăit in Paris pănă in 1940."; 
            }
            pictureBox1.BackgroundImage = new Bitmap("Personalitati\\" + variabile.Personalitatea + "\\1.jpg");
            textBox1.SelectionStart = textBox1.Text.Length;
            if (variabile.background == 1)
            {
                this.BackgroundImage = new Bitmap("backgrounds\\panouh.png");
                lblLectiiPers.ForeColor = Color.Black;
            }
            else if (variabile.background == 2)
            {
                this.BackgroundImage = new Bitmap("backgrounds\\black-wood-wallpaper.jpg");
                lblLectiiPers.ForeColor = Color.White;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            c++;
            if(c==4)
            {
                c = 1;
            }
            pictureBox1.BackgroundImage = new Bitmap("Personalitati\\" +variabile.Personalitatea + "\\" + c.ToString()  + ".jpg");
        }

        private void lectiiLeft_Click(object sender, EventArgs e)
        {
            c--;
            if (c == 0)
            {
                c = 3;
            }
            pictureBox1.BackgroundImage = new Bitmap("Personalitati\\" + variabile.Personalitatea + "\\" + c.ToString() + ".jpg");
        }

        Point LastPoint;

        private void frmLectii_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void frmLectii_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void closeLectii_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
