using MessageBoxEx.Logica.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace MessageBoxEx.Logica
{
    public class Information
    {
        #region Propiedades

        /// <summary>
        /// Devuelve o establece el texto que se va a mostrar
        /// </summary>
        /// <value>
        /// El texto que se va a mostrar
        /// </value>
        public string TextoAMostrar { get; set; }

        /// <summary>
        /// Devuelve o establece el texto de la barra de titulo que se va a mostrar
        /// </summary>
        /// <value>
        /// El texto de la barra de titulo que se va a mostrar
        /// </value>
        public string BarraDeTitulo { get; set; } = "";

        /// <summary>
        /// Devuelve o establece el valor de MessageBoxButton que especifica los botones que se van a mostrar
        /// </summary>
        /// <value>
        /// El valor de MessageBoxButton que especifica los botones que se van a mostrar
        /// </value>
        public MessageBoxButtonEx Botones { get; set; } = MessageBoxButtonEx.OK;

        /// <summary>
        /// Devuelve o establece un MessageBoxImage valor que especifica el icono para mostrar
        /// </summary>
        /// <value>
        /// El valor un MessageBoxImage valor que especifica el icono para mostrar
        /// </value>
        public MessageBoxImageEx Iconos { get; set; } = MessageBoxImageEx.None;

        public int Tiempo { get; set; } = 30;
        public bool MostrarTiempo { get; set; }
        public Labels Labels { get; set; } = new();

        public System.Windows.Media.Color ColorTexto { get; set; } = Colors.Black;

        #endregion
        private MessageBoxResultEx _botonPulsado = MessageBoxResultEx.OK;
        private Window _mensaje;
        private Label _labelTiempo = new();

        #region Tipos
        public enum MessageBoxButtonEx
        {
            OK,
            OKCancel,
            YesNo,
            YesNoCancel
        }
        private enum BotonesEstados
        {
            OK,
            Cancel,
            Yes,
            No
        }
        public enum MessageBoxResultEx
        {
            Cancel,
            No,
            None,
            OK,
            Yes
        }

        public enum MessageBoxImageEx
        {
            Asterisk,
            Error,
            Exclamation,
            Hand,
            Information,
            None,
            Question,
            Stop,
            Warning
        }


        #endregion


        /// <summary>
        /// Muestra un cuadro de mensaje que tiene un mensaje y que devuelve un resultado.
        /// </summary>
        /// <returns>
        /// El botón pulsado
        /// </returns>
        public MessageBoxResultEx Show()
        {
            crearVentana(BarraDeTitulo);

            StackPanel stackPanelContendor = new();
            _mensaje.Content = stackPanelContendor;

            stackPanelContendor.Children.Add(crearVentanaOculta(TextoAMostrar));
            stackPanelContendor.Children.Add(Iconos == MessageBoxImageEx.None
                ? crearMensaje(TextoAMostrar + Environment.NewLine)
                : crearMensaje(TextoAMostrar + Environment.NewLine, Iconos));

            StackPanel panelBotones = crearPanelBotones();
            stackPanelContendor.Children.Add(panelBotones);

            StackPanel stackPanel = new() { Orientation = Orientation.Horizontal, VerticalAlignment = VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Center, Margin = new Thickness(-5) };

            foreach (Button unBoton in createBotones(Botones))
            {
                stackPanel.Children.Add(unBoton);
            }

            panelBotones.Children.Add(stackPanel);
            _mensaje.Topmost = true;
            _mensaje.ShowDialog();
            return _botonPulsado;
        }

        /// <summary>
        /// Convierte el tipo de imagen en la imagen resultado
        /// </summary>
        /// <param name="imageEx">El tipo de imagen</param>
        /// <returns>La imagen</returns>
        private Bitmap convertImage(MessageBoxImageEx imageEx)
        {
            return imageEx switch
            {
                MessageBoxImageEx.Asterisk => Resources.Asterisk,
                MessageBoxImageEx.Error => Resources.Error,
                MessageBoxImageEx.Exclamation => Resources.Exclamation,
                MessageBoxImageEx.Hand => Resources.Hand,
                MessageBoxImageEx.Information => Resources.Information,
                MessageBoxImageEx.Question => Resources.Question,
                MessageBoxImageEx.Stop => Resources.Stop,
                MessageBoxImageEx.Warning => Resources.Warning,
                _ => Resources.Information
            };
        }

        private StackPanel crearPanelBotones() => new() { Background = new SolidColorBrush(Colors.DarkSeaGreen), Height = 50 };

        private StackPanel crearMensaje(string caption)
        {
            StackPanel stackPanel = new() { Orientation = Orientation.Horizontal, Background = new SolidColorBrush(Colors.White) };
            crearTiempo(stackPanel);

            stackPanel.Children.Add(new Label { Content = caption, Foreground = new SolidColorBrush(ColorTexto) });
            return stackPanel;
        }

        private StackPanel crearMensaje(string caption, MessageBoxImageEx icon)
        {
            StackPanel stackPanel = new() { Orientation = Orientation.Horizontal, Height = 50, Background = new SolidColorBrush(Colors.White) };
            crearTiempo(stackPanel);

            stackPanel.Children.Add(new System.Windows.Controls.Image { Source = convert(convertImage(icon)), Margin = new Thickness(5) });
            stackPanel.Children.Add(new Label { Content = caption, Foreground = new SolidColorBrush(ColorTexto) });
            return stackPanel;
        }

        /// <summary>
        /// Takes a bitmap and converts it to an image that can be handled by WPF ImageBrush
        /// </summary>
        /// <param name="src">A bitmap image</param>
        /// <returns>The image as a BitmapImage for WPF</returns>
        private BitmapImage convert(System.Drawing.Image src)
        {
            MemoryStream ms = new();
            src.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            BitmapImage image = new();
            image.BeginInit();
            ms.Seek(0, SeekOrigin.Begin);
            image.StreamSource = ms;
            image.EndInit();
            return image;
        }

        private StackPanel crearVentanaOculta(string messageBoxText)
        {
            StackPanel stackPanel = new() { Orientation = Orientation.Horizontal };
            if (messageBoxText.IndexOf(Environment.NewLine) != -1)
            {
                int size = 0;
                string lineaResultado = "";
                foreach (string linea in messageBoxText.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
                {
                    if (linea.Length >= size)
                    {
                        lineaResultado = linea;
                        size = linea.Length;
                    }
                }
                stackPanel.Children.Add(new Label { Content = lineaResultado, Visibility = Visibility.Hidden });
            }
            else
            {
                stackPanel.Children.Add(new Label { Content = messageBoxText, Visibility = Visibility.Hidden });
            }
            return stackPanel;
        }

        /// <summary>
        /// Crea una ventana messagebox
        /// </summary>
        /// <param name="titulo">El titulo</param>
        private void crearVentana(string titulo)
        {
            _mensaje = new Window
            {
                Top = 10,
                Left = 10,
                Width = 250,
                MinHeight = 150,
                Title = titulo,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                SizeToContent = SizeToContent.WidthAndHeight,
                WindowStyle = WindowStyle.ToolWindow
            };
            if (MostrarTiempo)
            {
                _mensaje.Loaded += mensaje_Loaded;
            }
        }

        private void mensaje_Loaded(object sender, RoutedEventArgs e)
        {
            DispatcherTimer timer = new()
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private IEnumerable<Button> createBotones(MessageBoxButtonEx button) => button switch
        {
            MessageBoxButtonEx.OK => new List<Button> { crearBoton(BotonesEstados.OK) },
            MessageBoxButtonEx.OKCancel => new List<Button> { crearBoton(BotonesEstados.OK), crearBoton(BotonesEstados.Cancel) },
            MessageBoxButtonEx.YesNo => new List<Button> { crearBoton(BotonesEstados.Yes), crearBoton(BotonesEstados.No) },
            MessageBoxButtonEx.YesNoCancel => new List<Button> { crearBoton(BotonesEstados.Yes), crearBoton(BotonesEstados.No), crearBoton(BotonesEstados.Cancel) },
            _ => new List<Button> { crearBoton(BotonesEstados.OK) }
        };

        private void boton_Click(object sender, RoutedEventArgs e)
        {
            Button aa = (Button)sender;
            _botonPulsado = (MessageBoxResultEx)aa.Tag;
            _mensaje.Close();
        }

        private void crearTiempo(Panel stackPanel)
        {
            if (MostrarTiempo)
            {
                _labelTiempo.Content = Tiempo;
                _labelTiempo.Visibility = Visibility.Visible;
                stackPanel.Children.Add(_labelTiempo);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Tiempo--;
            _labelTiempo.Content = Tiempo;
            if (Tiempo == 0)
            {
                _botonPulsado = Botones switch
                {
                    MessageBoxButtonEx.OK => MessageBoxResultEx.OK,
                    MessageBoxButtonEx.OKCancel => MessageBoxResultEx.OK,
                    MessageBoxButtonEx.YesNo => MessageBoxResultEx.Yes,
                    MessageBoxButtonEx.YesNoCancel => MessageBoxResultEx.Yes,
                    _ => MessageBoxResultEx.OK
                };
                _mensaje.Close();
            }
        }

        private Button crearBoton(BotonesEstados estadoBoton)
        {
            Button boton = new() { Height = 30, Margin = new Thickness(10), Padding = new Thickness(2), MinWidth = 100 };
            boton.Click += boton_Click;

            switch (estadoBoton)
            {
                case BotonesEstados.OK:
                    {
                        boton.Tag = MessageBoxResultEx.OK;
                        boton.Content = Labels.LabelOK;
                        boton.IsDefault = true;
                        boton.Focus();
                        _botonPulsado = MessageBoxResultEx.OK;
                        break;
                    }
                case BotonesEstados.Cancel:
                    {
                        boton.Tag = MessageBoxResultEx.Cancel;
                        boton.Content = Labels.LabelCancel;
                        boton.IsCancel = true;
                        _botonPulsado = MessageBoxResultEx.Cancel;
                        break;
                    }
                case BotonesEstados.No:
                    {
                        boton.Tag = MessageBoxResultEx.No;
                        boton.Content = Labels.LabelNo;
                        _botonPulsado = MessageBoxResultEx.No;
                        break;
                    }
                case BotonesEstados.Yes:
                    {
                        boton.Tag = MessageBoxResultEx.Yes;
                        boton.Content = Labels.LabelYes;
                        boton.IsDefault = true;
                        boton.Focus();
                        _botonPulsado = MessageBoxResultEx.No;
                        break;
                    }
                default:
                    {
                        boton.Tag = MessageBoxResultEx.OK;
                        boton.Content = Labels.LabelOK;
                        _botonPulsado = MessageBoxResultEx.OK;
                        break;
                    }
            }
            return boton;
        }
    }
}
