using Caliburn.Micro;
using GalaSoft.MvvmLight.Command;
using Microsoft.Win32;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Badge_Designer_Wpf.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        List<SolidColorBrush> Colors = new List<SolidColorBrush>
        {
            (SolidColorBrush)new BrushConverter().ConvertFromString("#E9C617"), //Gold
            (SolidColorBrush)new BrushConverter().ConvertFromString("#E2E2E2"), //Silvery White
            (SolidColorBrush)new BrushConverter().ConvertFromString("#FF0000"), //Red
            (SolidColorBrush)new BrushConverter().ConvertFromString("#3152F7"), //Blue
            (SolidColorBrush)new BrushConverter().ConvertFromString("#009600"), //Green
            (SolidColorBrush)new BrushConverter().ConvertFromString("#AA00AA"), //Purple
            (SolidColorBrush)new BrushConverter().ConvertFromString("#000000"), //Black
        };

        string DivUsed, OrdUsed, ChrUsed;

        public ShellViewModel()
        {
            //Populating Colors Lists

            ColorsList = new BindableCollection<SolidColorBrush>(Colors);

            //Initial Colors

            InitialColors();

            //Hiding all Elements 

            ResetVisibilities();

            ResetVisibilitiesOrd();

            ResetVisibilitiesChrg();
        }

        #region Color Properties

        private BindableCollection<SolidColorBrush> colorsList;

        public BindableCollection<SolidColorBrush> ColorsList
        {
            get { return colorsList; }
            set
            {
                colorsList = value;
                NotifyOfPropertyChange(() => ColorsList);
            }
        }

        private SolidColorBrush lineing;

        public SolidColorBrush Lineing
        {
            get { return lineing; }
            set
            {
                lineing = value;
                NotifyOfPropertyChange(() => Lineing);
            }
        }

        private SolidColorBrush mantling;

        public SolidColorBrush Mantling
        {
            get { return mantling; }
            set
            {
                mantling = value;
                NotifyOfPropertyChange(() => Mantling);
            }
        }

        private SolidColorBrush banner;

        public SolidColorBrush Banner
        {
            get { return banner; }
            set
            {
                banner = value;
                NotifyOfPropertyChange(() => Banner);
            }
        }

        private SolidColorBrush shield;

        public SolidColorBrush Shield
        {
            get { return shield; }
            set
            {
                shield = value;
                NotifyOfPropertyChange(() => Shield);
            }
        }

        private SolidColorBrush helmet;

        public SolidColorBrush Helmet
        {
            get { return helmet; }
            set
            {
                helmet = value;
                NotifyOfPropertyChange(() => Helmet);
            }
        }

        private SolidColorBrush division;

        public SolidColorBrush Division
        {
            get { return division; }
            set
            {
                division = value;
                NotifyOfPropertyChange(() => Division);
            }
        }

        private SolidColorBrush ordineries;

        public SolidColorBrush Ordinaries
        {
            get { return ordineries; }
            set
            {
                ordineries = value;
                NotifyOfPropertyChange(() => Ordinaries);
            }
        }

        private SolidColorBrush charges;

        public SolidColorBrush Charges
        {
            get { return charges; }
            set
            {
                charges = value;
                NotifyOfPropertyChange(() => Charges);
            }
        }

        private string bannerText;

        public string BannerText
        {
            get { return bannerText; }
            set
            {
                bannerText = value;
                NotifyOfPropertyChange(() => BannerText);
            }
        }

        #endregion

        #region Division's Visibilities

        private Visibility div1;

        public Visibility Div1
        {
            get { return div1; }
            set
            {
                div1 = value;
                NotifyOfPropertyChange(() => Div1);
            }
        }

        private Visibility div2;

        public Visibility Div2
        {
            get { return div2; }
            set
            {
                div2 = value;
                NotifyOfPropertyChange(() => Div2);
            }
        }

        private Visibility div3;

        public Visibility Div3
        {
            get { return div3; }
            set
            {
                div3 = value;
                NotifyOfPropertyChange(() => Div3);
            }
        }

        private Visibility div4;

        public Visibility Div4
        {
            get { return div4; }
            set
            {
                div4 = value;
                NotifyOfPropertyChange(() => Div4);
            }
        }

        private Visibility div5;

        public Visibility Div5
        {
            get { return div5; }
            set
            {
                div5 = value;
                NotifyOfPropertyChange(() => Div5);
            }
        }

        private Visibility div6;

        public Visibility Div6
        {
            get { return div6; }
            set
            {
                div6 = value;
                NotifyOfPropertyChange(() => Div6);
            }
        }

        private Visibility div7;

        public Visibility Div7
        {
            get { return div7; }
            set
            {
                div7 = value;
                NotifyOfPropertyChange(() => Div7);
            }
        }

        private Visibility div8;

        public Visibility Div8
        {
            get { return div8; }
            set
            {
                div8 = value;
                NotifyOfPropertyChange(() => Div8);
            }
        }


        #endregion

        #region Ordinaries' Visibilities

        private Visibility ord1;

        public Visibility Ord1
        {
            get { return ord1; }
            set
            {
                ord1 = value;
                NotifyOfPropertyChange(() => Ord1);
            }
        }

        private Visibility ord2;

        public Visibility Ord2
        {
            get { return ord2; }
            set
            {
                ord2 = value;
                NotifyOfPropertyChange(() => Ord2);
            }
        }

        private Visibility ord3;

        public Visibility Ord3
        {
            get { return ord3; }
            set
            {
                ord3 = value;
                NotifyOfPropertyChange(() => Ord3);
            }
        }

        private Visibility ord4;

        public Visibility Ord4
        {
            get { return ord4; }
            set
            {
                ord4 = value;
                NotifyOfPropertyChange(() => Ord4);
            }
        }

        private Visibility ord5;

        public Visibility Ord5
        {
            get { return ord5; }
            set
            {
                ord5 = value;
                NotifyOfPropertyChange(() => Ord5);
            }
        }

        private Visibility ord6;

        public Visibility Ord6
        {
            get { return ord6; }
            set
            {
                ord6 = value;
                NotifyOfPropertyChange(() => Ord6);
            }
        }

        private Visibility ord7;

        public Visibility Ord7
        {
            get { return ord7; }
            set
            {
                ord7 = value;
                NotifyOfPropertyChange(() => Ord7);
            }
        }

        private Visibility ord8;

        public Visibility Ord8
        {
            get { return ord8; }
            set
            {
                ord8 = value;
                NotifyOfPropertyChange(() => Ord8);
            }
        }

        private Visibility ord9;

        public Visibility Ord9
        {
            get { return ord9; }
            set
            {
                ord9 = value;
                NotifyOfPropertyChange(() => Ord9);
            }
        }

        private Visibility ord10;

        public Visibility Ord10
        {
            get { return ord10; }
            set
            {
                ord10 = value;
                NotifyOfPropertyChange(() => Ord10);
            }
        }

        private Visibility ord11;

        public Visibility Ord11
        {
            get { return ord11; }
            set
            {
                ord11 = value;
                NotifyOfPropertyChange(() => Ord11);
            }
        }

        private Visibility ord12;

        public Visibility Ord12
        {
            get { return ord12; }
            set
            {
                ord12 = value;
                NotifyOfPropertyChange(() => Ord12);
            }
        }

        private Visibility ord13;

        public Visibility Ord13
        {
            get { return ord13; }
            set
            {
                ord13 = value;
                NotifyOfPropertyChange(() => Ord13);
            }
        }

        #endregion

        #region Charges' Visibilities

        private Visibility chr1;

        public Visibility Chr1
        {
            get { return chr1; }
            set
            {
                chr1 = value;
                NotifyOfPropertyChange(() => Chr1);
            }
        }

        private Visibility chr2;

        public Visibility Chr2
        {
            get { return chr2; }
            set
            {
                chr2 = value;
                NotifyOfPropertyChange(() => Chr2);
            }
        }

        private Visibility chr3;

        public Visibility Chr3
        {
            get { return chr3; }
            set
            {
                chr3 = value;
                NotifyOfPropertyChange(() => Chr3);
            }
        }

        private Visibility chr4;

        public Visibility Chr4
        {
            get { return chr4; }
            set
            {
                chr4 = value;
                NotifyOfPropertyChange(() => Chr4);
            }
        }

        private Visibility chr5;

        public Visibility Chr5
        {
            get { return chr5; }
            set
            {
                chr5 = value;
                NotifyOfPropertyChange(() => Chr5);
            }
        }

        private Visibility chr6;

        public Visibility Chr6
        {
            get { return chr6; }
            set
            {
                chr6 = value;
                NotifyOfPropertyChange(() => Chr6);
            }
        }

        private Visibility chr7;

        public Visibility Chr7
        {
            get { return chr7; }
            set
            {
                chr7 = value;
                NotifyOfPropertyChange(() => Chr7);
            }
        }

        private Visibility chr8;

        public Visibility Chr8
        {
            get { return chr8; }
            set
            {
                chr8 = value;
                NotifyOfPropertyChange(() => Chr8);
            }
        }

        private Visibility chr9;

        public Visibility Chr9
        {
            get { return chr9; }
            set
            {
                chr9 = value;
                NotifyOfPropertyChange(() => Chr9);
            }
        }

        private Visibility chr10;

        public Visibility Chr10
        {
            get { return chr10; }
            set
            {
                chr10 = value;
                NotifyOfPropertyChange(() => Chr10);
            }
        }

        private Visibility chr11;

        public Visibility Chr11
        {
            get { return chr11; }
            set
            {
                chr11 = value;
                NotifyOfPropertyChange(() => Chr11);
            }
        }

        private Visibility chr12;

        public Visibility Chr12
        {
            get { return chr12; }
            set
            {
                chr12 = value;
                NotifyOfPropertyChange(() => Chr12);
            }
        }

        private Visibility chr13;

        public Visibility Chr13
        {
            get { return chr13; }
            set
            {
                chr13 = value;
                NotifyOfPropertyChange(() => Chr13);
            }
        }

        private Visibility chr14;

        public Visibility Chr14
        {
            get { return chr14; }
            set
            {
                chr14 = value;
                NotifyOfPropertyChange(() => Chr14);
            }
        }

        private Visibility chr15;

        public Visibility Chr15
        {
            get { return chr15; }
            set
            {
                chr15 = value;
                NotifyOfPropertyChange(() => Chr15);
            }
        }

        private Visibility chr16;

        public Visibility Chr16
        {
            get { return chr16; }
            set
            {
                chr16 = value;
                NotifyOfPropertyChange(() => Chr16);
            }
        }

        private Visibility chr17;

        public Visibility Chr17
        {
            get { return chr17; }
            set
            {
                chr17 = value;
                NotifyOfPropertyChange(() => Chr17);
            }
        }

        private Visibility chr18;

        public Visibility Chr18
        {
            get { return chr18; }
            set
            {
                chr18 = value;
                NotifyOfPropertyChange(() => Chr18);
            }
        }

        private Visibility chr19;

        public Visibility Chr19
        {
            get { return chr19; }
            set
            {
                chr19 = value;
                NotifyOfPropertyChange(() => Chr19);
            }
        }

        private Visibility chr20;

        public Visibility Chr20
        {
            get { return chr20; }
            set
            {
                chr20 = value;
                NotifyOfPropertyChange(() => Chr20);
            }
        }

        private Visibility chr21;

        public Visibility Chr21
        {
            get { return chr21; }
            set
            {
                chr21 = value;
                NotifyOfPropertyChange(() => Chr21);
            }
        }

        private Visibility chr22;

        public Visibility Chr22
        {
            get { return chr22; }
            set
            {
                chr22 = value;
                NotifyOfPropertyChange(() => Chr22);
            }
        }

        private Visibility chr23;

        public Visibility Chr23
        {
            get { return chr23; }
            set
            {
                chr23 = value;
                NotifyOfPropertyChange(() => Chr23);
            }
        }

        private Visibility chr24;

        public Visibility Chr24
        {
            get { return chr24; }
            set
            {
                chr24 = value;
                NotifyOfPropertyChange(() => Chr24);
            }
        }

        private Visibility chr25;

        public Visibility Chr25
        {
            get { return chr25; }
            set
            {
                chr25 = value;
                NotifyOfPropertyChange(() => Chr25);
            }
        }

        private Visibility chr26;

        public Visibility Chr26
        {
            get { return chr26; }
            set
            {
                chr26 = value;
                NotifyOfPropertyChange(() => Chr26);
            }
        }

        private Visibility chr27;

        public Visibility Chr27
        {
            get { return chr27; }
            set
            {
                chr27 = value;
                NotifyOfPropertyChange(() => Chr27);
            }
        }

        private Visibility chr28;

        public Visibility Chr28
        {
            get { return chr28; }
            set
            {
                chr28 = value;
                NotifyOfPropertyChange(() => Chr28);
            }
        }

        private Visibility chr29;

        public Visibility Chr29
        {
            get { return chr29; }
            set
            {
                chr29 = value;
                NotifyOfPropertyChange(() => Chr29);
            }
        }

        #endregion

        #region Functions to Show Divisions 

        void ResetVisibilities()
        {
            Div1 = Visibility.Collapsed;
            Div2 = Visibility.Collapsed;
            Div3 = Visibility.Collapsed;
            Div4 = Visibility.Collapsed;
            Div5 = Visibility.Collapsed;
            Div6 = Visibility.Collapsed;
            Div7 = Visibility.Collapsed;
            Div8 = Visibility.Collapsed;
            DivUsed = null;
        }

        public void ShowDiv1()
        {
            ResetVisibilities();
            Div1 = Visibility.Visible;
            DivUsed = "ShowDiv1";
        }

        public void ShowDiv2()
        {
            ResetVisibilities();
            Div2 = Visibility.Visible;
            DivUsed = "ShowDiv2";
        }

        public void ShowDiv3()
        {
            ResetVisibilities();
            Div3 = Visibility.Visible;
            DivUsed = "ShowDiv3";
        }

        public void ShowDiv4()
        {
            ResetVisibilities();
            Div4 = Visibility.Visible;
            DivUsed = "ShowDiv4";
        }

        public void ShowDiv5()
        {
            ResetVisibilities();
            Div5 = Visibility.Visible;
            DivUsed = "ShowDiv5";
        }

        public void ShowDiv6()
        {
            ResetVisibilities();
            Div6 = Visibility.Visible;
            DivUsed = "ShowDiv6";
        }

        public void ShowDiv7()
        {
            ResetVisibilities();
            Div7 = Visibility.Visible;
            DivUsed = "ShowDiv7";
        }

        public void ShowDiv8()
        {
            ResetVisibilities();
            Div8 = Visibility.Visible;
            DivUsed = "ShowDiv7";
        }

        public void ClearDiv()
        {
            ResetVisibilities();
        }

        #endregion

        #region Functions to Show Ordinaries

        void ResetVisibilitiesOrd()
        {
            Ord1 = Visibility.Collapsed;
            Ord2 = Visibility.Collapsed;
            Ord3 = Visibility.Collapsed;
            Ord4 = Visibility.Collapsed;
            Ord5 = Visibility.Collapsed;
            Ord6 = Visibility.Collapsed;
            Ord7 = Visibility.Collapsed;
            Ord8 = Visibility.Collapsed;
            Ord9 = Visibility.Collapsed;
            Ord10 = Visibility.Collapsed;
            Ord11 = Visibility.Collapsed;
            Ord12 = Visibility.Collapsed;
            Ord13 = Visibility.Collapsed;
            OrdUsed = null;
        }

        public void ShowOrd1()
        {
            ResetVisibilitiesOrd();
            Ord1 = Visibility.Visible;
            OrdUsed = "ShowOrd1";
        }

        public void ShowOrd2()
        {
            ResetVisibilitiesOrd();
            Ord2 = Visibility.Visible;
            OrdUsed = "ShowOrd2";
        }

        public void ShowOrd3()
        {
            ResetVisibilitiesOrd();
            Ord3 = Visibility.Visible;
            OrdUsed = "ShowOrd3";
        }

        public void ShowOrd4()
        {
            ResetVisibilitiesOrd();
            Ord4 = Visibility.Visible;
            OrdUsed = "ShowOrd4";
        }

        public void ShowOrd5()
        {
            ResetVisibilitiesOrd();
            Ord5 = Visibility.Visible;
            OrdUsed = "ShowOrd5";
        }

        public void ShowOrd6()
        {
            ResetVisibilitiesOrd();
            Ord6 = Visibility.Visible;
            OrdUsed = "ShowOrd6";
        }

        public void ShowOrd7()
        {
            ResetVisibilitiesOrd();
            Ord7 = Visibility.Visible;
            OrdUsed = "ShowOrd7";
        }

        public void ShowOrd8()
        {
            ResetVisibilitiesOrd();
            Ord8 = Visibility.Visible;
            OrdUsed = "ShowOrd8";
        }

        public void ShowOrd9()
        {
            ResetVisibilitiesOrd();
            Ord9 = Visibility.Visible;
            OrdUsed = "ShowOrd9";
        }

        public void ShowOrd10()
        {
            ResetVisibilitiesOrd();
            Ord10 = Visibility.Visible;
            OrdUsed = "ShowOrd10";
        }

        public void ShowOrd11()
        {
            ResetVisibilitiesOrd();
            Ord11 = Visibility.Visible;
            OrdUsed = "ShowOrd11";
        }

        public void ShowOrd12()
        {
            ResetVisibilitiesOrd();
            Ord12 = Visibility.Visible;
            OrdUsed = "ShowOrd12";
        }

        public void ShowOrd13()
        {
            ResetVisibilitiesOrd();
            Ord13 = Visibility.Visible;
            OrdUsed = "ShowOrd13";
        }

        public void ClearOrd()
        {
            ResetVisibilitiesOrd();
        }

        #endregion

        #region Functions to Show Charges

        void ResetVisibilitiesChrg()
        {
            Chr1 = Visibility.Collapsed;
            Chr2 = Visibility.Collapsed;
            Chr3 = Visibility.Collapsed;
            Chr4 = Visibility.Collapsed;
            Chr5 = Visibility.Collapsed;
            Chr6 = Visibility.Collapsed;
            Chr7 = Visibility.Collapsed;
            Chr8 = Visibility.Collapsed;
            Chr9 = Visibility.Collapsed;
            Chr10 = Visibility.Collapsed;
            Chr11 = Visibility.Collapsed;
            Chr12 = Visibility.Collapsed;
            Chr13 = Visibility.Collapsed;
            Chr14 = Visibility.Collapsed;
            Chr15 = Visibility.Collapsed;
            Chr16 = Visibility.Collapsed;
            Chr17 = Visibility.Collapsed;
            Chr18 = Visibility.Collapsed;
            Chr19 = Visibility.Collapsed;
            Chr20 = Visibility.Collapsed;
            Chr21 = Visibility.Collapsed;
            Chr22 = Visibility.Collapsed;
            Chr23 = Visibility.Collapsed;
            Chr24 = Visibility.Collapsed;
            Chr25 = Visibility.Collapsed;
            Chr26 = Visibility.Collapsed;
            Chr27 = Visibility.Collapsed;
            Chr28 = Visibility.Collapsed;
            Chr29 = Visibility.Collapsed;
            ChrUsed = null;
        }

        public void ShowChrAxe()
        {
            ResetVisibilitiesChrg();
            Chr1 = Visibility.Visible;
            ChrUsed = "ShowChrAxe";
        }

        public void ShowChrMace()
        {
            ResetVisibilitiesChrg();
            Chr2 = Visibility.Visible;
            ChrUsed = "ShowChrMace";
        }

        public void ShowChrEagle()
        {
            ResetVisibilitiesChrg();
            Chr3 = Visibility.Visible;
            ChrUsed = "ShowChrEagle";
        }

        public void ShowChrEagle_F()
        {
            ResetVisibilitiesChrg();
            Chr4 = Visibility.Visible;
            ChrUsed = "ShowChrEagle_F";
        }

        public void ShowChrEagle2()
        {
            ResetVisibilitiesChrg();
            Chr5 = Visibility.Visible;
            ChrUsed = "ShowChrEagle2";
        }

        public void ShowChrEagle2_F()
        {
            ResetVisibilitiesChrg();
            Chr6 = Visibility.Visible;
            ChrUsed = "ShowChrEagle2_F";
        }

        public void ShowChrCrest()
        {
            ResetVisibilitiesChrg();
            Chr7 = Visibility.Visible;
            ChrUsed = "ShowChrCrest";
        }

        public void ShowChrCrest2()
        {
            ResetVisibilitiesChrg();
            Chr8 = Visibility.Visible;
            ChrUsed = "ShowChrCrest2";
        }

        public void ShowChrDgr()
        {
            ResetVisibilitiesChrg();
            Chr9 = Visibility.Visible;
            ChrUsed = "ShowChrDgr";
        }

        public void ShowChrDgr2()
        {
            ResetVisibilitiesChrg();
            Chr10 = Visibility.Visible;
            ChrUsed = "ShowChrDgr2";
        }

        public void ShowChrCrown()
        {
            ResetVisibilitiesChrg();
            Chr11 = Visibility.Visible;
            ChrUsed = "ShowChrCrown";
        }

        public void ShowChrEsc()
        {
            ResetVisibilitiesChrg();
            Chr12 = Visibility.Visible;
            ChrUsed = "ShowChrEsc";
        }

        public void ShowChrGrab()
        {
            ResetVisibilitiesChrg();
            Chr13 = Visibility.Visible;
            ChrUsed = "ShowChrGrab";
        }

        public void ShowChrHand()
        {
            ResetVisibilitiesChrg();
            Chr14 = Visibility.Visible;
            ChrUsed = "ShowChrHand";
        }

        public void ShowChrGrf()
        {
            ResetVisibilitiesChrg();
            Chr15 = Visibility.Visible;
            ChrUsed = "ShowChrGrf";
        }

        public void ShowChrGrf_F()
        {
            ResetVisibilitiesChrg();
            Chr16 = Visibility.Visible;
            ChrUsed = "ShowChrGrf_F";
        }

        public void ShowChrGrf2()
        {
            ResetVisibilitiesChrg();
            Chr17 = Visibility.Visible;
            ChrUsed = "ShowChrEsc";
        }

        public void ShowChrGrf2_F()
        {
            ResetVisibilitiesChrg();
            Chr18 = Visibility.Visible;
            ChrUsed = "ShowChrGrf2_F";
        }

        public void ShowChrLion()
        {
            ResetVisibilitiesChrg();
            Chr19 = Visibility.Visible;
            ChrUsed = "ShowChrLion";
        }

        public void ShowChrLion_F()
        {
            ResetVisibilitiesChrg();
            Chr20 = Visibility.Visible;
            ChrUsed = "ShowChrLion_F";
        }

        public void ShowChrLion2()
        {
            ResetVisibilitiesChrg();
            Chr21 = Visibility.Visible;
            ChrUsed = "ShowChrLion2";
        }

        public void ShowChrLion2_F()
        {
            ResetVisibilitiesChrg();
            Chr22 = Visibility.Visible;
            ChrUsed = "ShowChrLion2_F";
        }

        public void ShowChrStag()
        {
            ResetVisibilitiesChrg();
            Chr23 = Visibility.Visible;
            ChrUsed = "ShowChrStag";
        }

        public void ShowChrStag_F()
        {
            ResetVisibilitiesChrg();
            Chr24 = Visibility.Visible;
            ChrUsed = "ShowChrStag_F";
        }

        public void ShowChrStag2()
        {
            ResetVisibilitiesChrg();
            Chr25 = Visibility.Visible;
            ChrUsed = "ShowChrStag2";
        }

        public void ShowChrSrd()
        {
            ResetVisibilitiesChrg();
            Chr26 = Visibility.Visible;
            ChrUsed = "ShowChrSrd";
        }

        public void ShowChrSrd2()
        {
            ResetVisibilitiesChrg();
            Chr27 = Visibility.Visible;
            ChrUsed = "ShowChrSrd2";
        }

        public void ShowChrBoar()
        {
            ResetVisibilitiesChrg();
            Chr28 = Visibility.Visible;
            ChrUsed = "ShowChrBoar";
        }

        public void ShowChrBoar_F()
        {
            ResetVisibilitiesChrg();
            Chr29 = Visibility.Visible;
            ChrUsed = "ShowChrBoar_F";
        }

        public void ClearChr()
        {
            ResetVisibilitiesChrg();
        }

        #endregion

        #region Template Setup

        public void temp1()
        {
            //Object to Store In Database

            //var ObjToStore = new
            //{
            //    Lineing = Lineing.Color.ToString(),
            //    Mantling = Mantling.Color.ToString(),
            //    Shield = Shield.Color.ToString(),
            //    Division = Division.Color.ToString(),
            //    Ordinaries = Ordinaries.Color.ToString(),
            //    Charges = Charges.Color.ToString(),
            //    Helmet = Helmet.Color.ToString(),
            //    Banner = Banner.Color.ToString(),

            //    BannerText,
            //    DivUsed,
            //    OrdUsed,
            //    ChrUsed
            //};

            //Imitating Data from Database

            var linDB = "#FF0000";
            var mantDB = "#E9C617";
            var fieldDb = "#000000";
            var divDB = "#3152F7";
            var ordDB = "#AA00AA";
            var chrDB = "#E2E2E2";
            var helDB = "#E2E2E2";
            var banDB = "#E9C617";

            var banText = "Template 1";

            var showDivDB = "ShowDiv4";
            var showOrdDB = "ShowOrd5";
            var showChrDB = "ShowChrStag_F";

            //Using Data to Generate Design

            Lineing = (SolidColorBrush)new BrushConverter().ConvertFromString(linDB);
            Mantling = (SolidColorBrush)new BrushConverter().ConvertFromString(mantDB);
            Shield = (SolidColorBrush)new BrushConverter().ConvertFromString(fieldDb);
            Division = (SolidColorBrush)new BrushConverter().ConvertFromString(divDB);
            Ordinaries = (SolidColorBrush)new BrushConverter().ConvertFromString(ordDB);
            Charges = (SolidColorBrush)new BrushConverter().ConvertFromString(chrDB);
            Helmet = (SolidColorBrush)new BrushConverter().ConvertFromString(helDB);
            Banner = (SolidColorBrush)new BrushConverter().ConvertFromString(banDB);

            BannerText = banText;

            GetType().GetMethod(showDivDB).Invoke(this, null);
            GetType().GetMethod(showOrdDB).Invoke(this, null);
            GetType().GetMethod(showChrDB).Invoke(this, null);
        }

        #endregion

        #region Tool bar Buttons

        public void Exit()
        {
            Application.Current.Shutdown();
        }

        public void Max()
        {
            if (Application.Current.MainWindow.WindowState == WindowState.Maximized)
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
            }
            else
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            }
        }

        public void Min()
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        #endregion

        //Save Badge to png

        public RelayCommand<FrameworkElement> PngCommand
        {
            get
            {
                return new RelayCommand<FrameworkElement>(v =>
                {
                    double scale = 600 / 96;
                    RenderTargetBitmap result = new RenderTargetBitmap
                    (
                      (int)(scale * (v.ActualWidth + 1)),
                      (int)(scale * (v.ActualHeight + 1)),
                      scale * 96,
                      scale * 96,
                      PixelFormats.Default
                    );
                    result.Render(v);

                    SaveFileDialog dlg = new SaveFileDialog();
                    dlg.Filter = "PNG files(*.png) | *.png";

                    if (dlg.ShowDialog() == true)
                    {
                        using (FileStream stream = File.Create(dlg.FileName))
                        {
                            PngBitmapEncoder encoder = new PngBitmapEncoder();

                            encoder.Frames.Add(BitmapFrame.Create(result));

                            encoder.Save(stream);
                        }
                    }

                });
            }
        }

        //Print Badge

        public RelayCommand<FrameworkElement> PrintCommand
        {
            get
            {
                return new RelayCommand<FrameworkElement>(v =>
                {
                    PrintDialog printDlg = new PrintDialog();
                    if (printDlg.ShowDialog() == true)
                    {
                        printDlg.PrintVisual(v, "Badge Printing");
                    }

                });
            }
        }

        void InitialColors()
        {
            Lineing = (SolidColorBrush)new BrushConverter().ConvertFromString("#E2E2E2");
            Mantling = (SolidColorBrush)new BrushConverter().ConvertFromString("#3152F7");
            Shield = (SolidColorBrush)new BrushConverter().ConvertFromString("#E2E2E2");
            Division = (SolidColorBrush)new BrushConverter().ConvertFromString("#3152F7");
            Ordinaries = (SolidColorBrush)new BrushConverter().ConvertFromString("#E2E2E2");
            Charges = (SolidColorBrush)new BrushConverter().ConvertFromString("#E2E2E2");
            Helmet = (SolidColorBrush)new BrushConverter().ConvertFromString("#E2E2E2");
            Banner = (SolidColorBrush)new BrushConverter().ConvertFromString("#E9C617");
        }
    }
}
