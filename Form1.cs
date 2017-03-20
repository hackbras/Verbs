using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerbosIrregulares
{
    public partial class Form1 : Form
    {
        public FlowLayoutPanel dynamicFlowLayoutPanel = new FlowLayoutPanel();

            
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            

            VerbosCS dbContext = new VerbosCS();

            Validacoes Conn = new Validacoes();

            Conn.FormatarCampos(lblPag1L1Trad, TbPag1L1_bas, TbPag1L1_pas, TbPag1L1_part, lblPag1L1_status);
            Conn.FormatarCampos(lblPag1L1Trad, TbPag1L1_bas, TbPag1L1_pas, TbPag1L1_part, lblPag1L1_status);
            Conn.FormatarCampos(lblPag1L2Trad, TbPag1L2_bas, TbPag1L2_pas, TbPag1L2_part, lblPag1L2_status);
            Conn.FormatarCampos(lblPag1L3Trad, TbPag1L3_bas, TbPag1L3_pas, TbPag1L3_part, lblPag1L3_status);
            Conn.FormatarCampos(lblPag1L4Trad, TbPag1L4_bas, TbPag1L4_pas, TbPag1L4_part, lblPag1L4_status);
            Conn.FormatarCampos(lblPag1L5Trad, TbPag1L5_bas, TbPag1L5_pas, TbPag1L5_part, lblPag1L5_status);
            Conn.FormatarCampos(lblPag1L6Trad, TbPag1L6_bas, TbPag1L6_pas, TbPag1L6_part, lblPag1L6_status);
            Conn.FormatarCampos(lblPag1L7Trad, TbPag1L7_bas, TbPag1L7_pas, TbPag1L7_part, lblPag1L7_status);
            Conn.FormatarCampos(lblPag1L8Trad, TbPag1L8_bas, TbPag1L8_pas, TbPag1L8_part, lblPag1L8_status);
            Conn.FormatarCampos(lblPag1L9Trad, TbPag1L9_bas, TbPag1L9_pas, TbPag1L9_part, lblPag1L9_status);
            Conn.FormatarCampos(lblPag1L10Trad, TbPag1L10_bas, TbPag1L10_pas, TbPag1L10_part, lblPag1L10_status);
            Conn.FormatarCampos(lblPag1L11Trad, TbPag1L11_bas, TbPag1L11_pas, TbPag1L11_part, lblPag1L11_status);
            Conn.FormatarCampos(lblPag1L12Trad, TbPag1L12_bas, TbPag1L12_pas, TbPag1L12_part, lblPag1L12_status);
            Conn.FormatarCampos(lblPag1L13Trad, TbPag1L13_bas, TbPag1L13_pas, TbPag1L13_part, lblPag1L13_status);
            Conn.FormatarCampos(lblPag1L14Trad, TbPag1L14_bas, TbPag1L14_pas, TbPag1L14_part, lblPag1L14_status);
            Conn.FormatarCampos(lblPag1L15Trad, TbPag1L15_bas, TbPag1L15_pas, TbPag1L15_part, lblPag1L15_status);
            Conn.FormatarCampos(lblPag1L16Trad, TbPag1L16_bas, TbPag1L16_pas, TbPag1L16_part, lblPag1L16_status);
            Conn.FormatarCampos(lblPag1L17Trad, TbPag1L17_bas, TbPag1L17_pas, TbPag1L17_part, lblPag1L17_status);
            Conn.FormatarCampos(lblPag1L18Trad, TbPag1L18_bas, TbPag1L18_pas, TbPag1L18_part, lblPag1L18_status);
            Conn.FormatarCampos(lblPag1L19Trad, TbPag1L19_bas, TbPag1L19_pas, TbPag1L19_part, lblPag1L19_status);
            Conn.FormatarCampos(lblPag1L20Trad, TbPag1L20_bas, TbPag1L20_pas, TbPag1L20_part, lblPag1L20_status);
            Conn.FormatarCampos(lblPag1L21Trad, TbPag1L21_bas, TbPag1L21_pas, TbPag1L21_part, lblPag1L21_status);
            Conn.FormatarCampos(lblPag1L22Trad, TbPag1L22_bas, TbPag1L22_pas, TbPag1L22_part, lblPag1L22_status);
            Conn.FormatarCampos(lblPag1L23Trad, TbPag1L23_bas, TbPag1L23_pas, TbPag1L23_part, lblPag1L23_status);
           // Conn.FormatarCampos(lblPag1L24Trad, TbPag1L24_bas, TbPag1L24_pas, TbPag1L24_part, lblPag1L24_status);
           // Conn.FormatarCampos(lblPag1L25Trad, TbPag1L25_bas, TbPag1L25_pas, TbPag1L25_part, lblPag1L25_status);
            //Conn.FormatarCampos(lblPag1L26Trad, TbPag1L26_bas, TbPag1L26_pas, TbPag1L26_part, lblPag1L26_status);
            //Conn.FormatarCampos(lblPag1L27Trad, TbPag1L27_bas, TbPag1L27_pas, TbPag1L27_part, lblPag1L27_status);
            //Conn.FormatarCampos(lblPag1L28Trad, TbPag1L28_bas, TbPag1L28_pas, TbPag1L28_part, lblPag1L28_status);
            //Conn.FormatarCampos(lblPag1L29Trad, TbPag1L29_bas, TbPag1L29_pas, TbPag1L29_part, lblPag1L29_status);
            //Conn.FormatarCampos(lblPag1L30Trad, TbPag1L30_bas, TbPag1L30_pas, TbPag1L30_part, lblPag1L30_status);
            //Conn.FormatarCampos(lblPag1L31Trad, TbPag1L31_bas, TbPag1L31_pas, TbPag1L31_part, lblPag1L31_status);
            //Conn.FormatarCampos(lblPag1L32Trad, TbPag1L32_bas, TbPag1L32_pas, TbPag1L32_part, lblPag1L32_status);
            //Conn.FormatarCampos(lblPag1L33Trad, TbPag1L33_bas, TbPag1L33_pas, TbPag1L33_part, lblPag1L33_status);
            //Conn.FormatarCampos(lblPag1L34Trad, TbPag1L34_bas, TbPag1L34_pas, TbPag1L34_part, lblPag1L34_status);
            //Conn.FormatarCampos(lblPag1L35Trad, TbPag1L35_bas, TbPag1L35_pas, TbPag1L35_part, lblPag1L35_status);
            //Conn.FormatarCampos(lblPag1L36Trad, TbPag1L36_bas, TbPag1L36_pas, TbPag1L36_part, lblPag1L36_status);
            //Conn.FormatarCampos(lblPag1L37Trad, TbPag1L37_bas, TbPag1L37_pas, TbPag1L37_part, lblPag1L37_status);
            //Conn.FormatarCampos(lblPag1L38Trad, TbPag1L38_bas, TbPag1L38_pas, TbPag1L38_part, lblPag1L38_status);
            //Conn.FormatarCampos(lblPag1L39Trad, TbPag1L39_bas, TbPag1L39_pas, TbPag1L39_part, lblPag1L39_status);
            //Conn.FormatarCampos(lblPag1L40Trad, TbPag1L40_bas, TbPag1L40_pas, TbPag1L40_part, lblPag1L40_status);
            //Conn.FormatarCampos(lblPag1L41Trad, TbPag1L41_bas, TbPag1L41_pas, TbPag1L41_part, lblPag1L41_status);
            //Conn.FormatarCampos(lblPag1L42Trad, TbPag1L42_bas, TbPag1L42_pas, TbPag1L42_part, lblPag1L42_status);
            //Conn.FormatarCampos(lblPag1L43Trad, TbPag1L43_bas, TbPag1L43_pas, TbPag1L43_part, lblPag1L43_status);
            //Conn.FormatarCampos(lblPag1L44Trad, TbPag1L44_bas, TbPag1L44_pas, TbPag1L44_part, lblPag1L44_status);
            //Conn.FormatarCampos(lblPag1L45Trad, TbPag1L45_bas, TbPag1L45_pas, TbPag1L45_part, lblPag1L45_status);
            //Conn.FormatarCampos(lblPag1L46Trad, TbPag1L46_bas, TbPag1L46_pas, TbPag1L46_part, lblPag1L46_status);
            //Conn.FormatarCampos(lblPag1L47Trad, TbPag1L47_bas, TbPag1L47_pas, TbPag1L47_part, lblPag1L47_status);
            //Conn.FormatarCampos(lblPag1L48Trad, TbPag1L48_bas, TbPag1L48_pas, TbPag1L48_part, lblPag1L48_status);
            //Conn.FormatarCampos(lblPag1L49Trad, TbPag1L49_bas, TbPag1L49_pas, TbPag1L49_part, lblPag1L49_status);
            //Conn.FormatarCampos(lblPag1L50Trad, TbPag1L50_bas, TbPag1L50_pas, TbPag1L50_part, lblPag1L50_status);
            //Conn.FormatarCampos(lblPag1L51Trad, TbPag1L51_bas, TbPag1L51_pas, TbPag1L51_part, lblPag1L51_status);
            //Conn.FormatarCampos(lblPag1L52Trad, TbPag1L52_bas, TbPag1L52_pas, TbPag1L52_part, lblPag1L52_status);
            //Conn.FormatarCampos(lblPag1L53Trad, TbPag1L53_bas, TbPag1L53_pas, TbPag1L53_part, lblPag1L53_status);
            //Conn.FormatarCampos(lblPag1L54Trad, TbPag1L54_bas, TbPag1L54_pas, TbPag1L54_part, lblPag1L54_status);
            //Conn.FormatarCampos(lblPag1L55Trad, TbPag1L55_bas, TbPag1L55_pas, TbPag1L55_part, lblPag1L55_status);
            //Conn.FormatarCampos(lblPag1L56Trad, TbPag1L56_bas, TbPag1L56_pas, TbPag1L56_part, lblPag1L56_status);
            //Conn.FormatarCampos(lblPag1L57Trad, TbPag1L57_bas, TbPag1L57_pas, TbPag1L57_part, lblPag1L57_status);
            //Conn.FormatarCampos(lblPag1L58Trad, TbPag1L58_bas, TbPag1L58_pas, TbPag1L58_part, lblPag1L58_status);
            //Conn.FormatarCampos(lblPag1L59Trad, TbPag1L59_bas, TbPag1L59_pas, TbPag1L59_part, lblPag1L59_status);
            //Conn.FormatarCampos(lblPag1L60Trad, TbPag1L60_bas, TbPag1L60_pas, TbPag1L60_part, lblPag1L60_status);
            //Conn.FormatarCampos(lblPag1L61Trad, TbPag1L61_bas, TbPag1L61_pas, TbPag1L61_part, lblPag1L61_status);
            //Conn.FormatarCampos(lblPag1L62Trad, TbPag1L62_bas, TbPag1L62_pas, TbPag1L62_part, lblPag1L62_status);
            //Conn.FormatarCampos(lblPag1L63Trad, TbPag1L63_bas, TbPag1L63_pas, TbPag1L63_part, lblPag1L63_status);
            //Conn.FormatarCampos(lblPag1L64Trad, TbPag1L64_bas, TbPag1L64_pas, TbPag1L64_part, lblPag1L64_status);
            //Conn.FormatarCampos(lblPag1L65Trad, TbPag1L65_bas, TbPag1L65_pas, TbPag1L65_part, lblPag1L65_status);
            //Conn.FormatarCampos(lblPag1L66Trad, TbPag1L66_bas, TbPag1L66_pas, TbPag1L66_part, lblPag1L66_status);
            //Conn.FormatarCampos(lblPag1L67Trad, TbPag1L67_bas, TbPag1L67_pas, TbPag1L67_part, lblPag1L67_status);
            //Conn.FormatarCampos(lblPag1L68Trad, TbPag1L68_bas, TbPag1L68_pas, TbPag1L68_part, lblPag1L68_status);
            //Conn.FormatarCampos(lblPag1L69Trad, TbPag1L69_bas, TbPag1L69_pas, TbPag1L69_part, lblPag1L69_status);
            //Conn.FormatarCampos(lblPag1L70Trad, TbPag1L70_bas, TbPag1L70_pas, TbPag1L70_part, lblPag1L70_status);
            //Conn.FormatarCampos(lblPag1L71Trad, TbPag1L71_bas, TbPag1L71_pas, TbPag1L71_part, lblPag1L71_status);
            //Conn.FormatarCampos(lblPag1L72Trad, TbPag1L72_bas, TbPag1L72_pas, TbPag1L72_part, lblPag1L72_status);
            //Conn.FormatarCampos(lblPag1L73Trad, TbPag1L73_bas, TbPag1L73_pas, TbPag1L73_part, lblPag1L73_status);
            //Conn.FormatarCampos(lblPag1L74Trad, TbPag1L74_bas, TbPag1L74_pas, TbPag1L74_part, lblPag1L74_status);
            //Conn.FormatarCampos(lblPag1L75Trad, TbPag1L75_bas, TbPag1L75_pas, TbPag1L75_part, lblPag1L75_status);
            //Conn.FormatarCampos(lblPag1L76Trad, TbPag1L76_bas, TbPag1L76_pas, TbPag1L76_part, lblPag1L76_status);
            //Conn.FormatarCampos(lblPag1L77Trad, TbPag1L77_bas, TbPag1L77_pas, TbPag1L77_part, lblPag1L77_status);
            //Conn.FormatarCampos(lblPag1L78Trad, TbPag1L78_bas, TbPag1L78_pas, TbPag1L78_part, lblPag1L78_status);
            //Conn.FormatarCampos(lblPag1L79Trad, TbPag1L79_bas, TbPag1L79_pas, TbPag1L79_part, lblPag1L79_status);
            //Conn.FormatarCampos(lblPag1L80Trad, TbPag1L80_bas, TbPag1L80_pas, TbPag1L80_part, lblPag1L80_status);
            //Conn.FormatarCampos(lblPag1L81Trad, TbPag1L81_bas, TbPag1L81_pas, TbPag1L81_part, lblPag1L81_status);
            //Conn.FormatarCampos(lblPag1L82Trad, TbPag1L82_bas, TbPag1L82_pas, TbPag1L82_part, lblPag1L82_status);
            //Conn.FormatarCampos(lblPag1L83Trad, TbPag1L83_bas, TbPag1L83_pas, TbPag1L83_part, lblPag1L83_status);
            //Conn.FormatarCampos(lblPag1L84Trad, TbPag1L84_bas, TbPag1L84_pas, TbPag1L84_part, lblPag1L84_status);
            //Conn.FormatarCampos(lblPag1L85Trad, TbPag1L85_bas, TbPag1L85_pas, TbPag1L85_part, lblPag1L85_status);
            //Conn.FormatarCampos(lblPag1L86Trad, TbPag1L86_bas, TbPag1L86_pas, TbPag1L86_part, lblPag1L86_status);
            //Conn.FormatarCampos(lblPag1L87Trad, TbPag1L87_bas, TbPag1L87_pas, TbPag1L87_part, lblPag1L87_status);
            //Conn.FormatarCampos(lblPag1L88Trad, TbPag1L88_bas, TbPag1L88_pas, TbPag1L88_part, lblPag1L88_status);
            //Conn.FormatarCampos(lblPag1L89Trad, TbPag1L89_bas, TbPag1L89_pas, TbPag1L89_part, lblPag1L89_status);
            //Conn.FormatarCampos(lblPag1L90Trad, TbPag1L90_bas, TbPag1L90_pas, TbPag1L90_part, lblPag1L90_status);
            //Conn.FormatarCampos(lblPag1L91Trad, TbPag1L91_bas, TbPag1L91_pas, TbPag1L91_part, lblPag1L91_status);
            //Conn.FormatarCampos(lblPag1L92Trad, TbPag1L92_bas, TbPag1L92_pas, TbPag1L92_part, lblPag1L92_status);
            //Conn.FormatarCampos(lblPag1L93Trad, TbPag1L93_bas, TbPag1L93_pas, TbPag1L93_part, lblPag1L93_status);
            //Conn.FormatarCampos(lblPag1L94Trad, TbPag1L94_bas, TbPag1L94_pas, TbPag1L94_part, lblPag1L94_status);
            //Conn.FormatarCampos(lblPag1L95Trad, TbPag1L95_bas, TbPag1L95_pas, TbPag1L95_part, lblPag1L95_status);
            //Conn.FormatarCampos(lblPag1L96Trad, TbPag1L96_bas, TbPag1L96_pas, TbPag1L96_part, lblPag1L96_status);
            //Conn.FormatarCampos(lblPag1L97Trad, TbPag1L97_bas, TbPag1L97_pas, TbPag1L97_part, lblPag1L97_status);
            //Conn.FormatarCampos(lblPag1L98Trad, TbPag1L98_bas, TbPag1L98_pas, TbPag1L98_part, lblPag1L98_status);
            //Conn.FormatarCampos(lblPag1L99Trad, TbPag1L99_bas, TbPag1L99_pas, TbPag1L99_part, lblPag1L99_status);
            //Conn.FormatarCampos(lblPag1L100Trad, TbPag1L100_bas, TbPag1L100_pas, TbPag1L100_part, lblPag1L100_status);
            //Conn.FormatarCampos(lblPag1L101Trad, TbPag1L101_bas, TbPag1L101_pas, TbPag1L101_part, lblPag1L101_status);
            //Conn.FormatarCampos(lblPag1L102Trad, TbPag1L102_bas, TbPag1L102_pas, TbPag1L102_part, lblPag1L102_status);
            //Conn.FormatarCampos(lblPag1L103Trad, TbPag1L103_bas, TbPag1L103_pas, TbPag1L103_part, lblPag1L103_status);
            //Conn.FormatarCampos(lblPag1L104Trad, TbPag1L104_bas, TbPag1L104_pas, TbPag1L104_part, lblPag1L104_status);
            //Conn.FormatarCampos(lblPag1L105Trad, TbPag1L105_bas, TbPag1L105_pas, TbPag1L105_part, lblPag1L105_status);
            //Conn.FormatarCampos(lblPag1L106Trad, TbPag1L106_bas, TbPag1L106_pas, TbPag1L106_part, lblPag1L106_status);
            //Conn.FormatarCampos(lblPag1L107Trad, TbPag1L107_bas, TbPag1L107_pas, TbPag1L107_part, lblPag1L107_status);
            //Conn.FormatarCampos(lblPag1L108Trad, TbPag1L108_bas, TbPag1L108_pas, TbPag1L108_part, lblPag1L108_status);
            //Conn.FormatarCampos(lblPag1L109Trad, TbPag1L109_bas, TbPag1L109_pas, TbPag1L109_part, lblPag1L109_status);
            //Conn.FormatarCampos(lblPag1L110Trad, TbPag1L110_bas, TbPag1L110_pas, TbPag1L110_part, lblPag1L110_status);
            //Conn.FormatarCampos(lblPag1L111Trad, TbPag1L111_bas, TbPag1L111_pas, TbPag1L111_part, lblPag1L111_status);
            //Conn.FormatarCampos(lblPag1L112Trad, TbPag1L112_bas, TbPag1L112_pas, TbPag1L112_part, lblPag1L112_status);
            //Conn.FormatarCampos(lblPag1L113Trad, TbPag1L113_bas, TbPag1L113_pas, TbPag1L113_part, lblPag1L113_status);
            //Conn.FormatarCampos(lblPag1L114Trad, TbPag1L114_bas, TbPag1L114_pas, TbPag1L114_part, lblPag1L114_status);
            //Conn.FormatarCampos(lblPag1L115Trad, TbPag1L115_bas, TbPag1L115_pas, TbPag1L115_part, lblPag1L115_status);
            //Conn.FormatarCampos(lblPag1L116Trad, TbPag1L116_bas, TbPag1L116_pas, TbPag1L116_part, lblPag1L116_status);
            //Conn.FormatarCampos(lblPag1L117Trad, TbPag1L117_bas, TbPag1L117_pas, TbPag1L117_part, lblPag1L117_status);
            //Conn.FormatarCampos(lblPag1L118Trad, TbPag1L118_bas, TbPag1L118_pas, TbPag1L118_part, lblPag1L118_status);
            //Conn.FormatarCampos(lblPag1L119Trad, TbPag1L119_bas, TbPag1L119_pas, TbPag1L119_part, lblPag1L119_status);
            //Conn.FormatarCampos(lblPag1L120Trad, TbPag1L120_bas, TbPag1L120_pas, TbPag1L120_part, lblPag1L120_status);
            //Conn.FormatarCampos(lblPag1L121Trad, TbPag1L121_bas, TbPag1L121_pas, TbPag1L121_part, lblPag1L121_status);
            //Conn.FormatarCampos(lblPag1L122Trad, TbPag1L122_bas, TbPag1L122_pas, TbPag1L122_part, lblPag1L122_status);
            //Conn.FormatarCampos(lblPag1L123Trad, TbPag1L123_bas, TbPag1L123_pas, TbPag1L123_part, lblPag1L123_status);
            //Conn.FormatarCampos(lblPag1L124Trad, TbPag1L124_bas, TbPag1L124_pas, TbPag1L124_part, lblPag1L124_status);
            //Conn.FormatarCampos(lblPag1L125Trad, TbPag1L125_bas, TbPag1L125_pas, TbPag1L125_part, lblPag1L125_status);
            //Conn.FormatarCampos(lblPag1L126Trad, TbPag1L126_bas, TbPag1L126_pas, TbPag1L126_part, lblPag1L126_status);
            //Conn.FormatarCampos(lblPag1L127Trad, TbPag1L127_bas, TbPag1L127_pas, TbPag1L127_part, lblPag1L127_status);
            //Conn.FormatarCampos(lblPag1L128Trad, TbPag1L128_bas, TbPag1L128_pas, TbPag1L128_part, lblPag1L128_status);
            //Conn.FormatarCampos(lblPag1L129Trad, TbPag1L129_bas, TbPag1L129_pas, TbPag1L129_part, lblPag1L129_status);
            //Conn.FormatarCampos(lblPag1L130Trad, TbPag1L130_bas, TbPag1L130_pas, TbPag1L130_part, lblPag1L130_status);
            //Conn.FormatarCampos(lblPag1L131Trad, TbPag1L131_bas, TbPag1L131_pas, TbPag1L131_part, lblPag1L131_status);
            //Conn.FormatarCampos(lblPag1L132Trad, TbPag1L132_bas, TbPag1L132_pas, TbPag1L132_part, lblPag1L132_status);
            //Conn.FormatarCampos(lblPag1L133Trad, TbPag1L133_bas, TbPag1L133_pas, TbPag1L133_part, lblPag1L133_status);
            //Conn.FormatarCampos(lblPag1L134Trad, TbPag1L134_bas, TbPag1L134_pas, TbPag1L134_part, lblPag1L134_status);
            //Conn.FormatarCampos(lblPag1L135Trad, TbPag1L135_bas, TbPag1L135_pas, TbPag1L135_part, lblPag1L135_status);
            //Conn.FormatarCampos(lblPag1L136Trad, TbPag1L136_bas, TbPag1L136_pas, TbPag1L136_part, lblPag1L136_status);
            //Conn.FormatarCampos(lblPag1L137Trad, TbPag1L137_bas, TbPag1L137_pas, TbPag1L137_part, lblPag1L137_status);
            //Conn.FormatarCampos(lblPag1L138Trad, TbPag1L138_bas, TbPag1L138_pas, TbPag1L138_part, lblPag1L138_status);
            //Conn.FormatarCampos(lblPag1L139Trad, TbPag1L139_bas, TbPag1L139_pas, TbPag1L139_part, lblPag1L139_status);
            //Conn.FormatarCampos(lblPag1L140Trad, TbPag1L140_bas, TbPag1L140_pas, TbPag1L140_part, lblPag1L140_status);
            //Conn.FormatarCampos(lblPag1L141Trad, TbPag1L141_bas, TbPag1L141_pas, TbPag1L141_part, lblPag1L141_status);
            //Conn.FormatarCampos(lblPag1L142Trad, TbPag1L142_bas, TbPag1L142_pas, TbPag1L142_part, lblPag1L142_status);
            //Conn.FormatarCampos(lblPag1L143Trad, TbPag1L143_bas, TbPag1L143_pas, TbPag1L143_part, lblPag1L143_status);
            //Conn.FormatarCampos(lblPag1L144Trad, TbPag1L144_bas, TbPag1L144_pas, TbPag1L144_part, lblPag1L144_status);
            //Conn.FormatarCampos(lblPag1L145Trad, TbPag1L145_bas, TbPag1L145_pas, TbPag1L145_part, lblPag1L145_status);
            //Conn.FormatarCampos(lblPag1L146Trad, TbPag1L146_bas, TbPag1L146_pas, TbPag1L146_part, lblPag1L146_status);
            //Conn.FormatarCampos(lblPag1L147Trad, TbPag1L147_bas, TbPag1L147_pas, TbPag1L147_part, lblPag1L147_status);
            //Conn.FormatarCampos(lblPag1L148Trad, TbPag1L148_bas, TbPag1L148_pas, TbPag1L148_part, lblPag1L148_status);
            //Conn.FormatarCampos(lblPag1L149Trad, TbPag1L149_bas, TbPag1L149_pas, TbPag1L149_part, lblPag1L149_status);
            //Conn.FormatarCampos(lblPag1L150Trad, TbPag1L150_bas, TbPag1L150_pas, TbPag1L150_part, lblPag1L150_status);
            //Conn.FormatarCampos(lblPag1L151Trad, TbPag1L151_bas, TbPag1L151_pas, TbPag1L151_part, lblPag1L151_status);
            //Conn.FormatarCampos(lblPag1L152Trad, TbPag1L152_bas, TbPag1L152_pas, TbPag1L152_part, lblPag1L152_status);
            //Conn.FormatarCampos(lblPag1L153Trad, TbPag1L153_bas, TbPag1L153_pas, TbPag1L153_part, lblPag1L153_status);
            //Conn.FormatarCampos(lblPag1L154Trad, TbPag1L154_bas, TbPag1L154_pas, TbPag1L154_part, lblPag1L154_status);
            //Conn.FormatarCampos(lblPag1L155Trad, TbPag1L155_bas, TbPag1L155_pas, TbPag1L155_part, lblPag1L155_status);
            //Conn.FormatarCampos(lblPag1L156Trad, TbPag1L156_bas, TbPag1L156_pas, TbPag1L156_part, lblPag1L156_status);
            //Conn.FormatarCampos(lblPag1L157Trad, TbPag1L157_bas, TbPag1L157_pas, TbPag1L157_part, lblPag1L157_status);
            //Conn.FormatarCampos(lblPag1L158Trad, TbPag1L158_bas, TbPag1L158_pas, TbPag1L158_part, lblPag1L158_status);
            //Conn.FormatarCampos(lblPag1L159Trad, TbPag1L159_bas, TbPag1L159_pas, TbPag1L159_part, lblPag1L159_status);
            //Conn.FormatarCampos(lblPag1L160Trad, TbPag1L160_bas, TbPag1L160_pas, TbPag1L160_part, lblPag1L160_status);
            //Conn.FormatarCampos(lblPag1L161Trad, TbPag1L161_bas, TbPag1L161_pas, TbPag1L161_part, lblPag1L161_status);
            //Conn.FormatarCampos(lblPag1L162Trad, TbPag1L162_bas, TbPag1L162_pas, TbPag1L162_part, lblPag1L162_status);
            //Conn.FormatarCampos(lblPag1L163Trad, TbPag1L163_bas, TbPag1L163_pas, TbPag1L163_part, lblPag1L163_status);
            //Conn.FormatarCampos(lblPag1L164Trad, TbPag1L164_bas, TbPag1L164_pas, TbPag1L164_part, lblPag1L164_status);
            //Conn.FormatarCampos(lblPag1L165Trad, TbPag1L165_bas, TbPag1L165_pas, TbPag1L165_part, lblPag1L165_status);
            //Conn.FormatarCampos(lblPag1L166Trad, TbPag1L166_bas, TbPag1L166_pas, TbPag1L166_part, lblPag1L166_status);
            //Conn.FormatarCampos(lblPag1L167Trad, TbPag1L167_bas, TbPag1L167_pas, TbPag1L167_part, lblPag1L167_status);
            //Conn.FormatarCampos(lblPag1L168Trad, TbPag1L168_bas, TbPag1L168_pas, TbPag1L168_part, lblPag1L168_status);
            //Conn.FormatarCampos(lblPag1L169Trad, TbPag1L169_bas, TbPag1L169_pas, TbPag1L169_part, lblPag1L169_status);
            //Conn.FormatarCampos(lblPag1L170Trad, TbPag1L170_bas, TbPag1L170_pas, TbPag1L170_part, lblPag1L170_status);
            //Conn.FormatarCampos(lblPag1L171Trad, TbPag1L171_bas, TbPag1L171_pas, TbPag1L171_part, lblPag1L171_status);
            //Conn.FormatarCampos(lblPag1L172Trad, TbPag1L172_bas, TbPag1L172_pas, TbPag1L172_part, lblPag1L172_status);
            //Conn.FormatarCampos(lblPag1L173Trad, TbPag1L173_bas, TbPag1L173_pas, TbPag1L173_part, lblPag1L173_status);
            //Conn.FormatarCampos(lblPag1L174Trad, TbPag1L174_bas, TbPag1L174_pas, TbPag1L174_part, lblPag1L174_status);
            //Conn.FormatarCampos(lblPag1L175Trad, TbPag1L175_bas, TbPag1L175_pas, TbPag1L175_part, lblPag1L175_status);
            //Conn.FormatarCampos(lblPag1L176Trad, TbPag1L176_bas, TbPag1L176_pas, TbPag1L176_part, lblPag1L176_status);
            //Conn.FormatarCampos(lblPag1L177Trad, TbPag1L177_bas, TbPag1L177_pas, TbPag1L177_part, lblPag1L177_status);
            //Conn.FormatarCampos(lblPag1L178Trad, TbPag1L178_bas, TbPag1L178_pas, TbPag1L178_part, lblPag1L178_status);
            //Conn.FormatarCampos(lblPag1L179Trad, TbPag1L179_bas, TbPag1L179_pas, TbPag1L179_part, lblPag1L179_status);
            //Conn.FormatarCampos(lblPag1L180Trad, TbPag1L180_bas, TbPag1L180_pas, TbPag1L180_part, lblPag1L180_status);
            //Conn.FormatarCampos(lblPag1L181Trad, TbPag1L181_bas, TbPag1L181_pas, TbPag1L181_part, lblPag1L181_status);
            //Conn.FormatarCampos(lblPag1L182Trad, TbPag1L182_bas, TbPag1L182_pas, TbPag1L182_part, lblPag1L182_status);
            //Conn.FormatarCampos(lblPag1L183Trad, TbPag1L183_bas, TbPag1L183_pas, TbPag1L183_part, lblPag1L183_status);
            //Conn.FormatarCampos(lblPag1L184Trad, TbPag1L184_bas, TbPag1L184_pas, TbPag1L184_part, lblPag1L184_status);
            //Conn.FormatarCampos(lblPag1L185Trad, TbPag1L185_bas, TbPag1L185_pas, TbPag1L185_part, lblPag1L185_status);
            //Conn.FormatarCampos(lblPag1L186Trad, TbPag1L186_bas, TbPag1L186_pas, TbPag1L186_part, lblPag1L186_status);
            //Conn.FormatarCampos(lblPag1L187Trad, TbPag1L187_bas, TbPag1L187_pas, TbPag1L187_part, lblPag1L187_status);
            //Conn.FormatarCampos(lblPag1L188Trad, TbPag1L188_bas, TbPag1L188_pas, TbPag1L188_part, lblPag1L188_status);
            //Conn.FormatarCampos(lblPag1L189Trad, TbPag1L189_bas, TbPag1L189_pas, TbPag1L189_part, lblPag1L189_status);
            //Conn.FormatarCampos(lblPag1L190Trad, TbPag1L190_bas, TbPag1L190_pas, TbPag1L190_part, lblPag1L190_status);
            //Conn.FormatarCampos(lblPag1L191Trad, TbPag1L191_bas, TbPag1L191_pas, TbPag1L191_part, lblPag1L191_status);
            //Conn.FormatarCampos(lblPag1L192Trad, TbPag1L192_bas, TbPag1L192_pas, TbPag1L192_part, lblPag1L192_status);
            //Conn.FormatarCampos(lblPag1L193Trad, TbPag1L193_bas, TbPag1L193_pas, TbPag1L193_part, lblPag1L193_status);
            //Conn.FormatarCampos(lblPag1L194Trad, TbPag1L194_bas, TbPag1L194_pas, TbPag1L194_part, lblPag1L194_status);
            //Conn.FormatarCampos(lblPag1L195Trad, TbPag1L195_bas, TbPag1L195_pas, TbPag1L195_part, lblPag1L195_status);
            //Conn.FormatarCampos(lblPag1L196Trad, TbPag1L196_bas, TbPag1L196_pas, TbPag1L196_part, lblPag1L196_status);
            //Conn.FormatarCampos(lblPag1L197Trad, TbPag1L197_bas, TbPag1L197_pas, TbPag1L197_part, lblPag1L197_status);
            //Conn.FormatarCampos(lblPag1L198Trad, TbPag1L198_bas, TbPag1L198_pas, TbPag1L198_part, lblPag1L198_status);
            //Conn.FormatarCampos(lblPag1L199Trad, TbPag1L199_bas, TbPag1L199_pas, TbPag1L199_part, lblPag1L199_status);
            //Conn.FormatarCampos(lblPag1L200Trad, TbPag1L200_bas, TbPag1L200_pas, TbPag1L200_part, lblPag1L200_status);
            //Conn.FormatarCampos(lblPag1L201Trad, TbPag1L201_bas, TbPag1L201_pas, TbPag1L201_part, lblPag1L201_status);
            //Conn.FormatarCampos(lblPag1L202Trad, TbPag1L202_bas, TbPag1L202_pas, TbPag1L202_part, lblPag1L202_status);
            //Conn.FormatarCampos(lblPag1L203Trad, TbPag1L203_bas, TbPag1L203_pas, TbPag1L203_part, lblPag1L203_status);
            //Conn.FormatarCampos(lblPag1L204Trad, TbPag1L204_bas, TbPag1L204_pas, TbPag1L204_part, lblPag1L204_status);
            //Conn.FormatarCampos(lblPag1L205Trad, TbPag1L205_bas, TbPag1L205_pas, TbPag1L205_part, lblPag1L205_status);
            //Conn.FormatarCampos(lblPag1L206Trad, TbPag1L206_bas, TbPag1L206_pas, TbPag1L206_part, lblPag1L206_status);
            //Conn.FormatarCampos(lblPag1L207Trad, TbPag1L207_bas, TbPag1L207_pas, TbPag1L207_part, lblPag1L207_status);
            //Conn.FormatarCampos(lblPag1L208Trad, TbPag1L208_bas, TbPag1L208_pas, TbPag1L208_part, lblPag1L208_status);
            //Conn.FormatarCampos(lblPag1L209Trad, TbPag1L209_bas, TbPag1L209_pas, TbPag1L209_part, lblPag1L209_status);
            //Conn.FormatarCampos(lblPag1L210Trad, TbPag1L210_bas, TbPag1L210_pas, TbPag1L210_part, lblPag1L210_status);
            //Conn.FormatarCampos(lblPag1L211Trad, TbPag1L211_bas, TbPag1L211_pas, TbPag1L211_part, lblPag1L211_status);
            //Conn.FormatarCampos(lblPag1L212Trad, TbPag1L212_bas, TbPag1L212_pas, TbPag1L212_part, lblPag1L212_status);
            //Conn.FormatarCampos(lblPag1L213Trad, TbPag1L213_bas, TbPag1L213_pas, TbPag1L213_part, lblPag1L213_status);
            //Conn.FormatarCampos(lblPag1L214Trad, TbPag1L214_bas, TbPag1L214_pas, TbPag1L214_part, lblPag1L214_status);
            //Conn.FormatarCampos(lblPag1L215Trad, TbPag1L215_bas, TbPag1L215_pas, TbPag1L215_part, lblPag1L215_status);
            //Conn.FormatarCampos(lblPag1L216Trad, TbPag1L216_bas, TbPag1L216_pas, TbPag1L216_part, lblPag1L216_status);
            //Conn.FormatarCampos(lblPag1L217Trad, TbPag1L217_bas, TbPag1L217_pas, TbPag1L217_part, lblPag1L217_status);
            //Conn.FormatarCampos(lblPag1L218Trad, TbPag1L218_bas, TbPag1L218_pas, TbPag1L218_part, lblPag1L218_status);
            //Conn.FormatarCampos(lblPag1L219Trad, TbPag1L219_bas, TbPag1L219_pas, TbPag1L219_part, lblPag1L219_status);
            //Conn.FormatarCampos(lblPag1L220Trad, TbPag1L220_bas, TbPag1L220_pas, TbPag1L220_part, lblPag1L220_status);
            //Conn.FormatarCampos(lblPag1L221Trad, TbPag1L221_bas, TbPag1L221_pas, TbPag1L221_part, lblPag1L221_status);
            //Conn.FormatarCampos(lblPag1L222Trad, TbPag1L222_bas, TbPag1L222_pas, TbPag1L222_part, lblPag1L222_status);
            //Conn.FormatarCampos(lblPag1L223Trad, TbPag1L223_bas, TbPag1L223_pas, TbPag1L223_part, lblPag1L223_status);
            //Conn.FormatarCampos(lblPag1L224Trad, TbPag1L224_bas, TbPag1L224_pas, TbPag1L224_part, lblPag1L224_status);
            //Conn.FormatarCampos(lblPag1L225Trad, TbPag1L225_bas, TbPag1L225_pas, TbPag1L225_part, lblPag1L225_status);
            //Conn.FormatarCampos(lblPag1L226Trad, TbPag1L226_bas, TbPag1L226_pas, TbPag1L226_part, lblPag1L226_status);
            //Conn.FormatarCampos(lblPag1L227Trad, TbPag1L227_bas, TbPag1L227_pas, TbPag1L227_part, lblPag1L227_status);
            //Conn.FormatarCampos(lblPag1L228Trad, TbPag1L228_bas, TbPag1L228_pas, TbPag1L228_part, lblPag1L228_status);
            //Conn.FormatarCampos(lblPag1L229Trad, TbPag1L229_bas, TbPag1L229_pas, TbPag1L229_part, lblPag1L229_status);
            //Conn.FormatarCampos(lblPag1L230Trad, TbPag1L230_bas, TbPag1L230_pas, TbPag1L230_part, lblPag1L230_status);
            //Conn.FormatarCampos(lblPag1L231Trad, TbPag1L231_bas, TbPag1L231_pas, TbPag1L231_part, lblPag1L231_status);
            //Conn.FormatarCampos(lblPag1L232Trad, TbPag1L232_bas, TbPag1L232_pas, TbPag1L232_part, lblPag1L232_status);
            //Conn.FormatarCampos(lblPag1L233Trad, TbPag1L233_bas, TbPag1L233_pas, TbPag1L233_part, lblPag1L233_status);
            //Conn.FormatarCampos(lblPag1L234Trad, TbPag1L234_bas, TbPag1L234_pas, TbPag1L234_part, lblPag1L234_status);
            //Conn.FormatarCampos(lblPag1L235Trad, TbPag1L235_bas, TbPag1L235_pas, TbPag1L235_part, lblPag1L235_status);
            //Conn.FormatarCampos(lblPag1L236Trad, TbPag1L236_bas, TbPag1L236_pas, TbPag1L236_part, lblPag1L236_status);
            //Conn.FormatarCampos(lblPag1L237Trad, TbPag1L237_bas, TbPag1L237_pas, TbPag1L237_part, lblPag1L237_status);
            //Conn.FormatarCampos(lblPag1L238Trad, TbPag1L238_bas, TbPag1L238_pas, TbPag1L238_part, lblPag1L238_status);
            //Conn.FormatarCampos(lblPag1L239Trad, TbPag1L239_bas, TbPag1L239_pas, TbPag1L239_part, lblPag1L239_status);
            //Conn.FormatarCampos(lblPag1L240Trad, TbPag1L240_bas, TbPag1L240_pas, TbPag1L240_part, lblPag1L240_status);
            //Conn.FormatarCampos(lblPag1L241Trad, TbPag1L241_bas, TbPag1L241_pas, TbPag1L241_part, lblPag1L241_status);
            //Conn.FormatarCampos(lblPag1L242Trad, TbPag1L242_bas, TbPag1L242_pas, TbPag1L242_part, lblPag1L242_status);
            //Conn.FormatarCampos(lblPag1L243Trad, TbPag1L243_bas, TbPag1L243_pas, TbPag1L243_part, lblPag1L243_status);
            //Conn.FormatarCampos(lblPag1L244Trad, TbPag1L244_bas, TbPag1L244_pas, TbPag1L244_part, lblPag1L244_status);


        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string teste = "testando";
            MessageBox.Show(teste.Substring(1,1));
        }
        
    }
}
