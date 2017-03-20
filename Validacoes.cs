using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace VerbosIrregulares
{
    class Validacoes
    {
        VerbosCS dbContext = new VerbosCS();

        public string Consultar(string translate,string baseForm,string pastSimple,string pastParticiple) { 
            
            var resultato = (from x in dbContext.fn_verbos(translate, baseForm, pastSimple, pastParticiple) select x.resultado).First();    
            
            return resultato;
        }

        public void FormatarCampos(Label translate, TextBox baseForm, TextBox pastSimple, TextBox pastParticiple, Label status)
        {
            string result;
            Validacoes Conn = new Validacoes();
            result = Conn.Consultar(translate.Text, baseForm.Text, pastSimple.Text, pastParticiple.Text);

            result.Substring(0, 1);

        
                switch (result.Substring(0,1))
                {
                    //
                    case "N":
                        switch (result.Substring(1,1))
                        {
                            case "N":
                                    switch (result)
                                    {
                                        case "NNN": baseForm.BackColor = Color.Yellow; pastSimple.BackColor = Color.Yellow; pastParticiple.BackColor = Color.Yellow; status.Text = "Vazio"; break;
                                        case "NNE": baseForm.BackColor = Color.Yellow; pastSimple.BackColor = Color.Yellow; pastParticiple.BackColor = Color.Red; status.Text = "Campos Vazios"; break;
                                        case "NNC": baseForm.BackColor = Color.Yellow; pastSimple.BackColor = Color.Yellow; pastParticiple.BackColor = Color.Green; status.Text = "Campos Vazios"; break;

                                    }
                                break;

                            case "C":
                                switch (result)
                                {
                                    case "NCC": baseForm.BackColor = Color.Yellow; pastSimple.BackColor = Color.Green; pastParticiple.BackColor = Color.Green; status.Text = "Campo Vazio"; break;
                                    case "NCN": baseForm.BackColor = Color.Yellow; pastSimple.BackColor = Color.Green; pastParticiple.BackColor = Color.Yellow; status.Text = "Campos Vazios"; break;
                                    case "NCE": baseForm.BackColor = Color.Yellow; pastSimple.BackColor = Color.Green; pastParticiple.BackColor = Color.Red; status.Text = "Campo Vazio"; break;

                                }
                                break;

                            case "E":
                                switch (result)
                                {
                                    case "NEC": baseForm.BackColor = Color.Yellow; pastSimple.BackColor = Color.Red; pastParticiple.BackColor = Color.Green; status.Text = "Campo Vazio"; break;
                                    case "NEN": baseForm.BackColor = Color.Yellow; pastSimple.BackColor = Color.Red; pastParticiple.BackColor = Color.Yellow; status.Text = "Campos Vazios"; break;
                                    case "NEE": baseForm.BackColor = Color.Yellow; pastSimple.BackColor = Color.Red; pastParticiple.BackColor = Color.Red; status.Text = "Campos Vazios"; break;

                                }
                                break;
                        }
                   break;


                   //
                    case "C":
                   switch (result.Substring(1,1))
                   {
                       case "N":
                           switch (result)
                           {
                               case "CNN": baseForm.BackColor = Color.Green; pastSimple.BackColor = Color.Yellow; pastParticiple.BackColor = Color.Yellow; status.Text = "Campos Vazios"; break;
                               case "CNC": baseForm.BackColor = Color.Green; pastSimple.BackColor = Color.Yellow; pastParticiple.BackColor = Color.Green; status.Text = "Campo Vazio"; break;
                               case "CNE": baseForm.BackColor = Color.Green; pastSimple.BackColor = Color.Yellow; pastParticiple.BackColor = Color.Red; status.Text = "Campo Vazio"; break;
                           }
                           break;

                       case "C":
                           switch (result)
                           {
                               case "CCN": baseForm.BackColor = Color.Green; pastSimple.BackColor = Color.Green; pastParticiple.BackColor = Color.Yellow; status.Text = "Campo Vazio"; break;
                               case "CCE": baseForm.BackColor = Color.Green; pastSimple.BackColor = Color.Green; pastParticiple.BackColor = Color.Red; status.Text = "Você está quase lá"; break;
                               case "CCC": baseForm.BackColor = Color.Green; pastSimple.BackColor = Color.Green; pastParticiple.BackColor = Color.Green; status.Text = "Certo"; break;

                           }
                           break;

                       case "E":
                           switch (result)
                           {

                               case "CEE": baseForm.BackColor = Color.Green; pastSimple.BackColor = Color.Red; pastParticiple.BackColor = Color.Red; status.Text = "Estude  Mais"; break;
                               case "CEC": baseForm.BackColor = Color.Green; pastSimple.BackColor = Color.Red; pastParticiple.BackColor = Color.Green; status.Text = "Você está quase lá"; break;
                               case "CEN": baseForm.BackColor = Color.Green; pastSimple.BackColor = Color.Red; pastParticiple.BackColor = Color.Yellow; status.Text = "Campo Vazio"; break;

                           }
                           break;
                   }
                   break;


                    //
                   case "E":
                   switch (result.Substring(1,1))
                   {
                       case "N":
                           switch (result)
                           {
                               case "ENE": baseForm.BackColor = Color.Red; pastSimple.BackColor = Color.Yellow; pastParticiple.BackColor = Color.Red; status.Text = "Estude Mais"; break;
                               case "ENC": baseForm.BackColor = Color.Red; pastSimple.BackColor = Color.Yellow; pastParticiple.BackColor = Color.Green; status.Text = "Campo Vazio"; break;
                               case "ENN": baseForm.BackColor = Color.Red; pastSimple.BackColor = Color.Yellow; pastParticiple.BackColor = Color.Yellow; status.Text = "Errados"; break;

                           }
                           break;

                       case "C":
                           switch (result)
                           {

                               case "ECC": baseForm.BackColor = Color.Red; pastSimple.BackColor = Color.Green; pastParticiple.BackColor = Color.Green; status.Text = "Você está quase lá"; break;
                               case "ECE": baseForm.BackColor = Color.Red; pastSimple.BackColor = Color.Green; pastParticiple.BackColor = Color.Red; status.Text = "Estude  Mais"; break;
                               case "ECN": baseForm.BackColor = Color.Red; pastSimple.BackColor = Color.Green; pastParticiple.BackColor = Color.Yellow; status.Text = "Campo Vazio"; break;

                           }
                           break;

                       case "E":
                           switch (result)
                           {
                               case "EEC": baseForm.BackColor = Color.Red; pastSimple.BackColor = Color.Red; pastParticiple.BackColor = Color.Green; status.Text = "Estude  Mais"; break;
                               case "EEE": baseForm.BackColor = Color.Red; pastSimple.BackColor = Color.Red; pastParticiple.BackColor = Color.Red; status.Text = "Errados"; break;
                               case "EEN": baseForm.BackColor = Color.Red; pastSimple.BackColor = Color.Red; pastParticiple.BackColor = Color.Red; status.Text = "Errados"; break;

                           }
                           break;
                   }
                   break;

                }
            }
        }

    }

