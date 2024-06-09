using SharpDX.DirectInput;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PInterfacesGrafico
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            Task.Run(() => CapturaBoton());

        }
        public void CapturaBoton()
        {

            var directInput = new DirectInput();
            var joystickGuid = Guid.Empty;

            foreach (var deviceInstance in directInput.GetDevices(
                DeviceType.Gamepad, DeviceEnumerationFlags.AllDevices))
            {
                joystickGuid = deviceInstance.InstanceGuid;
            }

            if (joystickGuid == Guid.Empty)
            {
                foreach (var deviceInstance in directInput.GetDevices(
                    DeviceType.Joystick, DeviceEnumerationFlags.AllDevices))
                {
                    joystickGuid = deviceInstance.InstanceGuid;
                }
            }

            if (joystickGuid == Guid.Empty)
            {
                //Console.WriteLine("No hay control conectado");
                lbEstado.Text = "No hay control conectado";
               
            }
            else
            {
                
                var joystick = new Joystick(directInput, joystickGuid);
                Console.WriteLine("El control es {0}", joystickGuid);
                

                joystick.Properties.BufferSize = 128;
                joystick.Acquire();

                while (true)
                {
                    joystick.Poll();
                    var data = joystick.GetBufferedData();

                    foreach (var state in data)
                    {
                        //Console.WriteLine($"Offset: {state.Offset}, Value: {state.Value}");

                        if (state.Offset.ToString().Contains("Button"))
                        {
                            int buttonNumber = int.Parse(state.Offset.ToString().Substring(state.Offset.ToString().Length - 1));

                            //if (state.Value == 128)
                            //{
                            //    Console.WriteLine($"Presionaste el botón {buttonNumber}");
                            //    pbBoton0.Image = Properties.Resources.BActivado;


                            //}
                            //else if (state.Value == 0)
                            //{
                            //    Console.WriteLine($"Soltaste el botón {buttonNumber}");
                            //}

                            switch(buttonNumber)
                            {
                                    case 0:

                                    if (state.Value == 128)
                                    {
                                        //ListEntradas.Text=$"Presionaste el botón {buttonNumber}";
                                        pbBoton0.Image = Properties.Resources.BActivado;


                                    }
                                    else if (state.Value == 0)
                                    {
                                        //ListEntradas.Text=$"Soltaste el botón {buttonNumber}";
                                        pbBoton0.Image = Properties.Resources.BDesactivado;
                                    }

                                    break;


                                    case 1:
                                    if (state.Value == 128)
                                    {
                                        //ListEntradas.Text = $"Presionaste el botón {buttonNumber}";
                                        pbBoton1.Image = Properties.Resources.BActivado;


                                    }
                                    else if (state.Value == 0)
                                    {
                                        //ListEntradas.Text = $"Soltaste el botón {buttonNumber}";
                                        pbBoton1.Image = Properties.Resources.BDesactivado;
                                    }
                                    break;


                                    case 2:
                                    if (state.Value == 128)
                                    {
                                        //ListEntradas.Text = $"Presionaste el botón {buttonNumber}";
                                        pbBoton2.Image = Properties.Resources.BActivado;


                                    }
                                    else if (state.Value == 0)
                                    {
                                        //ListEntradas.Text = $"Soltaste el botón {buttonNumber}";
                                        pbBoton2.Image = Properties.Resources.BDesactivado;
                                    }
                                    break;


                                    case 3:
                                    if (state.Value == 128)
                                    {
                                        //ListEntradas.Text = $"Presionaste el botón {buttonNumber}";
                                        pbBoton3.Image = Properties.Resources.BActivado;


                                    }
                                    else if (state.Value == 0)
                                    {
                                        //ListEntradas.Text = $"Soltaste el botón {buttonNumber}";
                                        pbBoton3.Image = Properties.Resources.BDesactivado;
                                    }
                                    break;

                                    case 4:
                                    if (state.Value == 128)
                                    {
                                        //ListEntradas.Text = $"Presionaste el botón {buttonNumber}";
                                        pbBoton4.Image = Properties.Resources.BActivado;


                                    }
                                    else if (state.Value == 0)
                                    {
                                        //ListEntradas.Text = $"Soltaste el botón {buttonNumber}";
                                        pbBoton4.Image = Properties.Resources.BDesactivado;
                                    }
                                    break;


                                    case 5:
                                    if (state.Value == 128)
                                    {
                                        //ListEntradas.Text = $"Presionaste el botón {buttonNumber}";
                                        pbBoton5.Image = Properties.Resources.BActivado;


                                    }
                                    else if (state.Value == 0)
                                    {
                                        //ListEntradas.Text = $"Soltaste el botón {buttonNumber}";
                                        pbBoton5.Image = Properties.Resources.BDesactivado;
                                    }
                                    break;


                                    case 6:
                                    if (state.Value == 128)
                                    {
                                        //ListEntradas.Text = $"Presionaste el botón {buttonNumber}";
                                        pbBoton6.Image = Properties.Resources.BActivado;


                                    }
                                    else if (state.Value == 0)
                                    {
                                        //ListEntradas.Text = $"Soltaste el botón {buttonNumber}";
                                        pbBoton6.Image = Properties.Resources.BDesactivado;
                                    }
                                    break;


                                    case 7:
                                    if (state.Value == 128)
                                    {
                                        //ListEntradas.Text = $"Presionaste el botón {buttonNumber}";
                                        pbBoton7.Image = Properties.Resources.BActivado;


                                    }
                                    else if (state.Value == 0)
                                    {
                                        //ListEntradas.Text = $"Soltaste el botón {buttonNumber}";
                                        pbBoton7.Image = Properties.Resources.BDesactivado;
                                    }
                                    break;

                                    case 8:
                                    if (state.Value == 128)
                                    {
                                        //ListEntradas.Text = $"Presionaste el botón {buttonNumber}";
                                        pbBoton8.Image = Properties.Resources.BActivado;


                                    }
                                    else if (state.Value == 0)
                                    {
                                        //ListEntradas.Text = $"Soltaste el botón {buttonNumber}";
                                        pbBoton8.Image = Properties.Resources.BDesactivado;
                                    }
                                    break;


                                    case 9:
                                    if (state.Value == 128)
                                    {
                                        //ListEntradas.Text = $"Presionaste el botón {buttonNumber}";
                                        pbBoton9.Image = Properties.Resources.BActivado;


                                    }
                                    else if (state.Value == 0)
                                    {
                                        //ListEntradas.Text = $"Soltaste el botón {buttonNumber}";
                                        pbBoton9.Image = Properties.Resources.BDesactivado;
                                    }
                                    break;


                            }

                        }
                        else if (state.Offset.ToString().Contains("X"))
                        {
                            // Imprimir el valor sin procesar
                            Console.WriteLine($"Valor del eje X: {state.Value}");

                            if (state.Value == 0)
                            {
                                //Console.WriteLine("Presionaste la palanca en el eje X hacia la izquierda");
                                pbFlechaIzquierda.Image = Properties.Resources.FIActivada;
                            }
                            else if (state.Value == 65535)
                            {
                                //Console.WriteLine("Presionaste la palanca en el eje X hacia la derecha");
                                pbFlechaDerecha.Image = Properties.Resources.FDActivada;
                            }
                            else if (state.Value == 32511)
                            {
                                //Console.WriteLine("Soltaste la palanca en el eje X");
                                pbFlechaIzquierda.Image = Properties.Resources.FIDesactivada;
                                pbFlechaDerecha.Image = Properties.Resources.FDDesactivada;
                            }
                        }

                        else if (state.Offset.ToString().Contains("Y"))
                        {
                            // Imprimir el valor sin procesar
                            Console.WriteLine($"Valor del eje Y: {state.Value}");

                            if (state.Value == 0)
                            {
                                //Console.WriteLine("Presionaste la palanca en el eje Y hacia la Arriba");
                                pbFlechaArriba.Image = Properties.Resources.FAActivada;
                            }
                            else if (state.Value == 65535)
                            {
                                //Console.WriteLine("Presionaste la palanca en el eje Y hacia la Abajo");
                                pbFlechaAbajo.Image = Properties.Resources.FABActivada;
                            }
                            else if (state.Value == 32511)
                            {
                                //Console.WriteLine("Soltaste la palanca en el eje Y");
                                pbFlechaArriba.Image = Properties.Resources.FADesactivada;
                                pbFlechaAbajo.Image = Properties.Resources.FABDesactivada;
                            }
                        }


                    }
                }

            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
