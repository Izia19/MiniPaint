using System;
using System.Reflection.Emit;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace minipaint
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public bool button_clicked;

        public bool Rectangle;
        public bool Ellipse;
        public bool Line;
        public bool Label;

        public Shape figura;
        public System.Windows.Controls.Label label;

        public Color kolor_figury;
        public Point obecny_pnt;

        public bool czy_wpisana_wartosc = false;
        public bool przesun = false;
        public bool gumka = false;
        public bool edycja = false;


        private void wybierz_figure(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if(button != null && gumka == false)
            {
                switch (button.Tag.ToString())
                {
                    case "Rectangle":
                        Rectangle = true;
                        Ellipse = false;
                        Line = false;
                        Label = false;
                        break;

                    case "Elipse":
                        Rectangle = false;
                        Ellipse = true;
                        Line = false;
                        Label = false;
                        break;

                    case "Line":  
                        Rectangle = false;
                        Ellipse = false;
                        Line = true;
                        Label = false;
                        break;

                    case "Label":
                        Rectangle = false;
                        Ellipse = false;
                        Line = false;
                        Label = true;
                        break;

                    default:
                        break;
                }
            }
            else if(gumka == true)
            {
                MessageBox.Show("Masz właczoną gumkę");
            }
        }

        //lewy przycisk
        private void lewy_przycisk_down(object sender, MouseButtonEventArgs e)
        {
            if (gumka == true)
            {
                Point clickPoint = e.GetPosition(Canvas);
                HitTestResult hitTestResult = VisualTreeHelper.HitTest(Canvas, clickPoint);

                if (hitTestResult != null)
                {
                    if (hitTestResult.VisualHit is Shape)
                    {
                        Canvas.Children.Remove((Shape)hitTestResult.VisualHit);
                    }
                    else if (hitTestResult.VisualHit is System.Windows.Controls.Label)
                    {
                        Canvas.Children.Remove((System.Windows.Controls.Label)hitTestResult.VisualHit);
                    }
                }
            }
            else
            {
                button_clicked = true;
                obecny_pnt = e.GetPosition(Canvas);

                if(Line == true)
                {
                    figura = new Line { Stroke = new SolidColorBrush(kolor_figury) };

                    if (!string.IsNullOrEmpty(Szerokosc_line.Text) && Convert.ToDouble(Szerokosc_line.Text) > 0)
                    {
                        try
                        {
                            ((Line)figura).StrokeThickness = Convert.ToDouble(Szerokosc_line.Text);
                        }
                        catch
                        {
                            MessageBox.Show("Wystąpił bład");
                            return;
                        }
                    }
                    else
                    {
                        ((Line)figura).StrokeThickness = 3;
                    }
                    ((Line)figura).X1 = obecny_pnt.X;
                    ((Line)figura).Y1 = obecny_pnt.Y;

                    Canvas.Children.Add(figura);
                    return;

                }
                else if (Rectangle || Ellipse)
                {
                    figura = Rectangle ? new Rectangle { Fill = new SolidColorBrush(kolor_figury) } : new Ellipse { Fill = new SolidColorBrush(kolor_figury) };
                }
                else if(Label == true)
                {
                    button_clicked = false;

                    label = new System.Windows.Controls.Label();
                    label.BorderBrush = Brushes.Green;
                    label.BorderThickness = new Thickness(3);
                    label.SetValue(Canvas.LeftProperty, obecny_pnt.X);
                    label.SetValue(Canvas.TopProperty, obecny_pnt.Y);
                    Canvas.Children.Add(label);

                    label.Focusable = true;
                    label.KeyDown += label_KeyDown;
                    label.Focus();
                    return;
                }

                if (figura != null)
                {
                    figura.SetValue(Canvas.LeftProperty, obecny_pnt.X);
                    figura.SetValue(Canvas.TopProperty, obecny_pnt.Y);
                    Canvas.Children.Add(figura);
                }
                else
                {
                    MessageBox.Show("Wybierz figure by rysowac");
                } 
            }
        }

        private void lewy_przycisk_up(object sender, MouseButtonEventArgs e)
        {
            button_clicked = false;
        }

        //prawy przycisk
        private void prawy_przycisk_down(object sender, MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
            {
                obecny_pnt = e.GetPosition(Canvas);
                przesun = true;

                HitTestResult hitTestResult = VisualTreeHelper.HitTest(Canvas, obecny_pnt);
                if (hitTestResult != null && hitTestResult.VisualHit is Shape)
                {
                    figura = (Shape)hitTestResult.VisualHit;
                }
            }
        }

        private void prawy_przycisk_up(object sender, MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Released && przesun == true)
            {
                przesun = false;
            }
        }

        private void rysuj(object sender, MouseEventArgs e)
        {
            try
            {
                if (figura != null)
                {
                    if (button_clicked == true && gumka == false)
                    {
                        Point nowy_pnt = e.GetPosition(Canvas);

                        double width = nowy_pnt.X - obecny_pnt.X;
                        double height = nowy_pnt.Y - obecny_pnt.Y;

                        if (!czy_wpisana_wartosc || Convert.ToDouble(Szerokosc.Text) == 0 || Convert.ToDouble(Wysokosc.Text) == 0)
                        {
                            szerokosc_wysokosc(Convert.ToInt16(Math.Abs(height)), Convert.ToInt16(Math.Abs(width)));
                            if (figura is Line)
                            {
                                ((Line)figura).X2 = nowy_pnt.X;
                                ((Line)figura).Y2 = nowy_pnt.Y;
                            }
                            else
                            {
                                if (width < 0)
                                {
                                    figura.SetValue(Canvas.LeftProperty, nowy_pnt.X);
                                    figura.Width = -width;
                                }
                                else
                                {
                                    figura.Width = width;
                                }

                                if (height < 0)
                                {
                                    figura.SetValue(Canvas.TopProperty, nowy_pnt.Y);
                                    figura.Height = -height;
                                }
                                else
                                {
                                    figura.Height = height;
                                }
                            }
                        }
                        else
                        {
                            if (figura is Line)
                            {
                                ((Line)figura).X2 = nowy_pnt.X;
                                ((Line)figura).Y2 = nowy_pnt.Y;
                            }
                            else
                            {
                                figura.Width = Convert.ToDouble(Szerokosc.Text);
                                figura.Height = Convert.ToDouble(Wysokosc.Text);
                            }
                        }
                    }
                    if (przesun == true)
                    {
                        Point nowy_pnt = e.GetPosition(Canvas);

                        double pnt_x = nowy_pnt.X - obecny_pnt.X;
                        double pnt_y = nowy_pnt.Y - obecny_pnt.Y;

                        figura.SetValue(Canvas.LeftProperty, (double)figura.GetValue(Canvas.LeftProperty) + pnt_x);
                        figura.SetValue(Canvas.TopProperty, (double)figura.GetValue(Canvas.TopProperty) + pnt_y);

                        obecny_pnt = nowy_pnt;

                        if (figura is Line)
                        {
                            ((Line)figura).X1 += pnt_x;
                            ((Line)figura).Y1 += pnt_y;
                            ((Line)figura).X2 += pnt_x;
                            ((Line)figura).Y2 += pnt_y;
                        }
                    } 
                }
            }
            catch
            {
                MessageBox.Show("Wystąpił błąd");
            }
        }

        private void zmien_color(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            if (comboBox != null && comboBox.SelectedItem != null)
            {
                ComboBoxItem selectedItem = comboBox.SelectedItem as ComboBoxItem;

                if (selectedItem != null)
                {
                    try
                    {
                        kolor_figury = (Color)ColorConverter.ConvertFromString(selectedItem.Content.ToString());
                    }
                    catch
                    {
                        MessageBox.Show("Wystąpił błąd");
                    }
                }
            }
        }

        private void wpisana_wartosc(object sender, TextChangedEventArgs e)
        {
            if(edycja == false)
            {
                czy_wpisana_wartosc = true;
            }      
        }

        private void szerokosc_wysokosc(int wysokosc, int szerokosc)
        {
            czy_wpisana_wartosc = true;
            Szerokosc.Text = szerokosc.ToString();
            Wysokosc.Text = wysokosc.ToString();
            czy_wpisana_wartosc = false;
        }

        private void wyczysc_wysokosc_szerokosc(object sender, EventArgs e)
        {
            Szerokosc.Text = "0";
            Wysokosc.Text = "0";
        }

        private void edycja_true(object sender, EventArgs e)
        {
            if (gumka == true)
            {
                MessageBox.Show("Jesteś w trybie czyszczenia");
                return;
            }
            else if((Edycja_button.Content).ToString() == "Edytuj")
            {
                Edycja_button.Content = "Zatwierdz";
                Edycja_button.Background = Brushes.LightGreen;
                edycja = true;

            }
            else if((Edycja_button.Content).ToString() == "Zatwierdz")
            {
                Edycja_button.Content = "Edytuj";
                Edycja_button.Background = Brushes.Pink;
                edycja = false;
                edytuj_figure();
            }        
        }

        public void edytuj_figure()
        {
            if(!string.IsNullOrEmpty(Szerokosc.Text) && !string.IsNullOrEmpty(Wysokosc.Text) && Convert.ToDouble(Szerokosc.Text) > 0 && Convert.ToDouble(Wysokosc.Text) > 0)
            {
                figura.Width = Convert.ToDouble(Szerokosc.Text);
                figura.Height = Convert.ToDouble(Wysokosc.Text);
            }
            else
            {
                MessageBox.Show("Wysokosc ani szerokosc nie moze byc równa 0");
            }     
        }    

        private void gumka_true(object sender, EventArgs e)
        {
            if ((Gumka_button.Content).ToString() == "Gumka")
            {
                Gumka_button.Content = "Czyszczenie";
                Gumka_button.Background = Brushes.LightGreen;
                gumka = true;
            }
            else if ((Gumka_button.Content).ToString() == "Czyszczenie")
            {
                Gumka_button.Content = "Gumka";
                Gumka_button.Background = Brushes.Pink;
                gumka = false;
            }
        }

        private void label_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                ((System.Windows.Controls.Label)sender).IsEnabled = false;
                label.BorderBrush = Brushes.Red;

                //druga opcja bo nie jestem pewna czy rozumiem polecenie tak jak trzeba
                //Canvas.Children.Remove(label);
            }
            else
            {
                ((System.Windows.Controls.Label)sender).Content += e.Key.ToString();
            }
        }

        private void tylko_cyfra(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !czy_cyfra(e.Text);
        }

        private bool czy_cyfra(string input)
        {
            return int.TryParse(input, out _);
        }
    }
}