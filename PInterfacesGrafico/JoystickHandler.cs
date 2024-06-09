using SharpDX.DirectInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PInterfacesGrafico
{
    internal class JoystickHandler
    {

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
                Console.WriteLine("No hay control conectado");
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

                            if (state.Value == 128)
                            {
                                Console.WriteLine($"Presionaste el botón {buttonNumber}");
                                

                            }
                            else if (state.Value == 0)
                            {
                                Console.WriteLine($"Soltaste el botón {buttonNumber}");
                            }
                        }
                        else if (state.Offset.ToString().Contains("X"))
                        {
                            // Imprimir el valor sin procesar
                            Console.WriteLine($"Valor del eje X: {state.Value}");

                            if (state.Value == 0)
                            {
                                Console.WriteLine("Presionaste la palanca en el eje X hacia la izquierda");
                            }
                            else if (state.Value == 65535)
                            {
                                Console.WriteLine("Presionaste la palanca en el eje X hacia la derecha");
                            }
                            else if (state.Value == 32511)
                            {
                                Console.WriteLine("Soltaste la palanca en el eje X");
                            }
                        }

                        else if (state.Offset.ToString().Contains("Y"))
                        {
                            // Imprimir el valor sin procesar
                            Console.WriteLine($"Valor del eje Y: {state.Value}");

                            if (state.Value == 0)
                            {
                                Console.WriteLine("Presionaste la palanca en el eje Y hacia la Arriba");
                            }
                            else if (state.Value == 65535)
                            {
                                Console.WriteLine("Presionaste la palanca en el eje Y hacia la Abajo");
                            }
                            else if (state.Value == 32511)
                            {
                                Console.WriteLine("Soltaste la palanca en el eje Y");
                            }
                        }


                    }
                }

            }



        }
}
}
