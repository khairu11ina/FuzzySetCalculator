using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions; 
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace FuzzySetCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) // Происходит до первоначального отображения формы
                                                            // при каждой загрузке данной формы пользователем
        {
            btn_debug.Enabled = false;
        }
        /*******************************************************************************************************************************************************/
        static uint[] GetValueU(TextBox tBox_mnvo) //создание массива для U
        {
            uint[] uint_mnvo_U = null;
            string[] mnvo_U = tBox_mnvo.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            uint n; // далее n-преобразованное значение
            uint_mnvo_U = new uint[mnvo_U.GetLength(0)];//объявляем мн-во 
            for (int i = 0; i < mnvo_U.GetLength(0); i++)
            {
                if (!uint.TryParse(mnvo_U[i], out n))//преобразование типов//n-преобразованное значение
                {
                    //tBox_mnvo.Clear();
                    uint_mnvo_U = null;
                    break;
                }
                else
                    uint_mnvo_U[i] = n;//заполнение нового int массива                                 
            }
            ////////////////////////////////////////////////////////////////////////
            if (uint_mnvo_U != null)
            {
                int validate = 0;
                for (int i = 0; i < uint_mnvo_U.GetLength(0); i++) // идём по знаменателям // проверяем входит ли A в U
                {
                    for (int t = 0; t < uint_mnvo_U.GetLength(0); t++)
                    {
                        if (uint_mnvo_U[i] == uint_mnvo_U[t])
                            validate++; // встретился эл-т
                    }
                    if (validate != 1)// эл-т встречается не один раз, т.е. встретилось повторение
                    {
                        uint_mnvo_U = null;
                        break;
                    }
                    validate = 0;
                }

                uint buf;
                for (int i = 1; i < uint_mnvo_U.GetLength(0); i += 2) // сортируем пузырьком
                {
                    for (int j = 1; j < uint_mnvo_U.GetLength(0); j += 2)
                    {
                        if (uint_mnvo_U[j] > uint_mnvo_U[j - 1])
                        {
                            buf = uint_mnvo_U[j];
                            uint_mnvo_U[j] = uint_mnvo_U[j - 1];
                            uint_mnvo_U[j - 1] = buf;
                        }
                    }
                }

            }
            return (uint_mnvo_U);
        }
        /*******************************************************************************************************************************************************/
        static double[] GetValueAB(TextBox tBox_mnvo) //создание массивов для А, В
        {
            double[] double_mnvo = null;
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            bool validate = true; // проверка на соответствие
            Regex regex1 = new Regex(@"^\s*(0\,\d+|1|0)\/\d+\s*$"); // если убрать +, и проверять на дроби (н-р: 0,1/1)
            string[] proverka_mnvo1 = tBox_mnvo.Text.Split('+');
            for (int i = 0; i < proverka_mnvo1.GetLength(0); i++)
            {
                if (regex1.IsMatch(proverka_mnvo1[i]) == false)//IsMatch - проверяет, совпадает ли рег. выр-е из regex с входной строкой(на выходе true/false)
                    validate = false;
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Regex regex2 = new Regex(@"^\s*\d+\s*\+\s*(0\,\d+|1|0)\s*$"); // если убрать /, и проверять на + (н-р: 1 + 0,2)
            string[] proverka_mnvo2 = tBox_mnvo.Text.Split('/');
            for (int i = 1; i < proverka_mnvo2.GetLength(0) - 1; i++)
            {
                if (regex2.IsMatch(proverka_mnvo2[i]) == false) //IsMatch - проверяет, совпадает ли рег. выр-е из regex с входной строкой(на выходе true/false)
                    validate = false;
            }
            // отдельные проверки для первого и последнего эл-та (0,1 и 6)
            double n;
            if (!double.TryParse(proverka_mnvo2[0], out n))// если все плохо
                validate = false;
            int m;
            if (!int.TryParse(proverka_mnvo2[proverka_mnvo2.GetLength(0) - 1], out m))
                validate = false;

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////                 
            if (validate == true)
            {
                string[] mnvo = tBox_mnvo.Text.Split('+', '/'); // лепка массива числ и знаменат с мусором путем обрезания плюсов и слешей
                double_mnvo = new double[mnvo.GetLength(0)];//объявляем мн-во разделенных числителей и знаменателей длины string мн-ва
                                                            // четные - числители, нечетные - знаменатели
                for (int i = 0; i < mnvo.GetLength(0); i++)// убираем мусор
                {
                    mnvo[i] = mnvo[i].Trim(new char[] { ' ' }); //Trim для обрезки начальных и конечных символов
                    double_mnvo[i] = double.Parse(mnvo[i]);
                }
            }
            double buf;
            try
            {
                for (int i = 1; i < double_mnvo.GetLength(0); i += 2)  // сортируем пузырьком
                {
                    for (int j = 1; j < double_mnvo.GetLength(0) - 2; j += 2)
                    {
                        if (double_mnvo[j] > double_mnvo[j + 2])
                        {
                            buf = double_mnvo[j]; // меняем местами знаменатели 
                            double_mnvo[j] = double_mnvo[j + 2];
                            double_mnvo[j + 2] = buf;

                            buf = double_mnvo[j - 1]; // меняем местами числители
                            double_mnvo[j - 1] = double_mnvo[j + 1];
                            double_mnvo[j + 1] = buf;
                        }
                    }
                }
            }
            catch(NullReferenceException )
            {
                MessageBox.Show("ОШИБКА! \nПроверьте правильность введенных данных");
            }

            return (double_mnvo);
        }
        /*******************************************************************************************************************************************************/
        static bool CheckToU(uint[] double_mnvo_U, double[] double_mnvo_A)  // проверка на вхождение А в U, а также проверка на наличие повторений в А (0,1/1 + 0,2/1)
        {
            int validate = 0; // проверка на наличие повторений в А
            for (int i = 1; i < double_mnvo_A.GetLength(0); i += 2) // идём по знаменателям // проверяем входит ли A в U
            {
                for (int t = 1; t < double_mnvo_A.GetLength(0); t += 2)
                {
                    if (double_mnvo_A[i] == double_mnvo_A[t])
                        validate++; // встретился эл-т
                }
                if (validate != 1)// эл-т встречается не один раз, т.е. встретилось повторение                
                    return (false);
                validate = 0;
                /////////////////////////////////////////////////////////
                bool check = false; // проверка на вхождение А в U
                for (int j = 0; j < double_mnvo_U.GetLength(0); j++)
                {
                    if (double_mnvo_A[i] == double_mnvo_U[j])
                        check = true; // эл-т содержится в U
                }
                if (check == false)
                    return (false);
                check = false;
            }
            return (true);
        }
        /*******************************************************************************************************************************************************/
        static void CheckToCoincidence(ref double[] double_mnvo_A, ref double[] double_mnvo_B, /*ref*/ Chart crt_grafik) // нормируем мн-ва и рисуем их графики
        {// учитываются только эл-ты с одинаковыми U
            int coincidence = 0; // совпадение
            for (int i = 1; i < double_mnvo_A.GetLength(0); i += 2) // сравниваем у // обнуляем по А
            {
                /*for (int j = 1; j < double_mnvo_B.GetLength(0); j += 2)
                {
                    if (double_mnvo_A[i] == double_mnvo_B[j])
                        coincidence++;
                }
                if (coincidence == 0) // если ни разу не совпало - обнуляем (т.е. не учитываем)
                    double_mnvo_A[i - 1] = 0; //числитель
               //else*/
                    crt_grafik.Series[1].Points.AddXY(double_mnvo_A[i], double_mnvo_A[i - 1]);
                coincidence = 0;
            }

            for (int i = 1; i < double_mnvo_B.GetLength(0); i += 2) // сравниваем у // обнуляем по В
            {
                /*for (int j = 1; j < double_mnvo_A.GetLength(0); j += 2)
                {
                    if (double_mnvo_B[i] == double_mnvo_A[j])
                        coincidence++;
                }
                if (coincidence == 0) // если ни разу не совпало - обнуляем (т.е. не учитываем)
                    double_mnvo_B[i - 1] = 0; //числитель
               // else */
                    crt_grafik.Series[0].Points.AddXY(double_mnvo_B[i], double_mnvo_B[i - 1]);
                coincidence = 0;
            }
        }
        /*******************************************************************************************************************************************************/
        private void btn_debug_Click(object sender, EventArgs e)
        {
            crt_grafik.Series[0].Points.Clear(); // чистим график
            crt_grafik.Series[1].Points.Clear();
            crt_grafik.Series[2].Points.Clear();

            for (int i = 0; i < 5; i++)
            {
                crt_grafik.Legends[i].Enabled = false;
            }

            uint[] uint_mnvo_U = null; // нужно только для проверки
            if (tBox_U.Text != "") // пока в tBox_U лежит что-то
                uint_mnvo_U = GetValueU(tBox_U); // вызываем метод, который лепит массив U

            double[] double_mnvo_A = null;
            if (tBox_A.Text != "") // пока в tBox_A лежит что-то
                double_mnvo_A = GetValueAB(tBox_A); // вызываем метод, который лепит массив для А 
            double[] double_mnvo_B = null;
            
            if ((uint_mnvo_U != null) && (double_mnvo_A != null) && (CheckToU(uint_mnvo_U, double_mnvo_A) == true))
            {
                ////////////////////////////////////////////////////////////////////////////////////////////////////////

                if (radioButton0.Checked) // "Пересечение" 
                ///////////////////////////////////////////////////////////////// 
                {
                    crt_grafik.Legends[0].Enabled = true; // включаем нужнцю легенду графика

                    crt_grafik.Series[0].BorderColor = Color.Transparent;
                    crt_grafik.Series[0].ChartType = SeriesChartType.Area;
                    crt_grafik.Series[0].BackHatchStyle = ChartHatchStyle.OutlinedDiamond;
                    crt_grafik.Series[0].Color = Color.MediumPurple;

                    crt_grafik.Series[1].BorderColor = Color.Transparent;
                    crt_grafik.Series[1].ChartType = SeriesChartType.Area;

                    if (tBox_B.Text != "") // если в tBox лежит что-то
                        double_mnvo_B = GetValueAB(tBox_B); // вызываем метод, который лепит массив для B
                    if (double_mnvo_B != null)
                    {
                        if (CheckToU(uint_mnvo_U, double_mnvo_B) == true)
                        {
                            CheckToCoincidence(ref double_mnvo_A, ref double_mnvo_B, /*ref*/ crt_grafik); // нормируем и выводим мн-ва
                        }
                        else
                        {
                            MessageBox.Show("ОШИБКА! \nПроверьте правильность введенных данных в В");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("ОШИБКА! \nПроверьте правильность введенных данных в В");
                        return;
                    }
                }

                else if (radioButton1.Checked) // объединение 
                {
                    ///////////////////////////////////////////////////////////////// 0,2/2 + 0,3/3 + 0,4/4+ 0,5/5
                    crt_grafik.Legends[1].Enabled = true;
                    crt_grafik.Series[0].Color = Color.HotPink;
                    crt_grafik.Series[0].BorderColor = Color.MediumPurple;
                    crt_grafik.Series[0].ChartType = SeriesChartType.Area;
                    crt_grafik.Series[0].BackHatchStyle = ChartHatchStyle.Percent50;
                    crt_grafik.Series[1].BorderColor = Color.HotPink;
                    crt_grafik.Series[1].ChartType = SeriesChartType.Area;

                    if (tBox_B.Text != "") // пока в tBox лежит что-то
                        double_mnvo_B = GetValueAB(tBox_B); // вызываем метод, который лепит массив для B
                    if (double_mnvo_B != null)
                    {
                        if (CheckToU(uint_mnvo_U, double_mnvo_B) == true)
                        {
                            CheckToCoincidence(ref double_mnvo_A, ref double_mnvo_B, /*ref*/ crt_grafik); // нормируем и выводим мн-ва                            
                        }
                        else
                        {
                            MessageBox.Show("ОШИБКА! \nПроверьте правильность введенных данных в В");
                            tBox_B.Clear();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("ОШИБКА! \nПроверьте правильность введенных данных в В");
                        return;
                    }
                    return;
                }
                else if (radioButton2.Checked) //отриц                
                {
                    ///////////////////////////////////////////////////////////////// 
                    crt_grafik.Legends[2].Enabled = true;

                    crt_grafik.Series[2].Color = Color.White;
                    crt_grafik.Series[2].BorderColor = Color.HotPink;
                    crt_grafik.Series[2].MarkerColor = Color.Transparent;
                    crt_grafik.Series[2].ChartType = SeriesChartType.Area;

                    crt_grafik.Series[1].BorderColor = Color.Transparent;
                    crt_grafik.Series[1].ChartType = SeriesChartType.Area;

                    for (int i = 0; i < double_mnvo_A.GetLength(0); i += 2) // по Х - U, по У - double
                    {
                        crt_grafik.Series[2].Points.AddXY(double_mnvo_A[i + 1], Math.Abs(1 - double_mnvo_A[i]));
                        crt_grafik.Series[1].Points.AddXY(double_mnvo_A[i + 1], 1);
                    }
                }

                else if (radioButton4.Checked) //возв в степень
                {
                    /////////////////////////////////////////////////////////////////
                    {
                        crt_grafik.Legends[3].Enabled = true;
                        crt_grafik.Series[0].ChartType = SeriesChartType.Area;
                        crt_grafik.Series[0].BorderColor = Color.HotPink;
                        crt_grafik.Series[0].Color = Color.HotPink;
                        crt_grafik.Series[1].BorderColor = Color.MediumPurple;
                        crt_grafik.Series[1].Color = Color.MediumPurple;
                        crt_grafik.Series[1].ChartType = SeriesChartType.Area;

                        uint degree = 0;
                        if (!uint.TryParse(tBox_B.Text, out degree))//преобразование типов//n-преобразованное значение
                        {
                            MessageBox.Show("ОШИБКА! \nПроверьте правильность введенных данных. \nВозвести можно только в целую неотрицательную степень");
                            tBox_B.Clear();
                            return;
                        }
                        if (degree != 0)
                        {
                            for (int i = 0; i < double_mnvo_A.GetLength(0); i += 2) // по Х - U, по У - double
                            {
                                if ((double_mnvo_A[i] * degree) <= 1)
                                {
                                    crt_grafik.Series[0].Points.AddXY(double_mnvo_A[i + 1], Math.Pow(double_mnvo_A[i], degree));
                                }
                            }
                            /////////////////////////////////////////////////////////////////
                            for (int i = 0; i < double_mnvo_A.GetLength(0); i += 2) // по Х - U, по У - double //просто вывели А
                            {
                                crt_grafik.Series[1].Points.AddXY(double_mnvo_A[i + 1], double_mnvo_A[i]);
                            }
                        }
                    }
                }
                else if (radioButton3.Checked) //умнож на числ
                {
                    /////////////////////////////////////////////////////////////////
                    {
                        crt_grafik.Legends[3].Enabled = true;
                        crt_grafik.Series[0].ChartType = SeriesChartType.Area;
                        crt_grafik.Series[0].BorderColor = Color.HotPink;
                        crt_grafik.Series[0].Color = Color.HotPink;
                        crt_grafik.Series[1].Color = Color.MediumPurple;
                        crt_grafik.Series[1].BorderColor = Color.MediumPurple;
                        crt_grafik.Series[1].ChartType = SeriesChartType.Area;

                        double number = 0;
                        if (!double.TryParse(tBox_B.Text, out number))//преобразование типов//n-преобразованное значение
                        {
                            MessageBox.Show("ОШИБКА! \nПроверьте правильность введенных данных.");
                            tBox_B.Clear();
                        }
                        if (number >= 0)
                        {
                            for (int i = 0; i < double_mnvo_A.GetLength(0); i += 2) // по Х - U, по У - double
                            {
                                if ((double_mnvo_A[i] * number) <= 1)
                                    crt_grafik.Series[0].Points.AddXY(double_mnvo_A[i + 1], double_mnvo_A[i] * number);
                                else
                                {
                                    MessageBox.Show("ОШИБКА! \nПроверьте правильность введенных данных!");
                                    number = -100;
                                    break;
                                }
                            }
                            /////////////////////////////////////////////////////////////////
                            if (number != -100)
                            {
                                for (int i = 0; i < double_mnvo_A.GetLength(0); i += 2) // по Х - U, по У - double //просто вывели А
                                {
                                    crt_grafik.Series[1].Points.AddXY(double_mnvo_A[i + 1], double_mnvo_A[i]);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("ОШИБКА! \nПроверьте правильность введенных данных. \nЧисто не может быть отрицательным");
                        }
                    }
                }

                else if (radioButton5.Checked) //произвед // тут все слишком мудрено, чтобы этим в час ночи заниматься
                {
                    /////////////////////////////////////////////////////////////////
                    crt_grafik.Legends[4].Enabled = true;
                    crt_grafik.Series[2].Color = Color.Red;
                    crt_grafik.Series[2].MarkerColor = Color.Red;
                    crt_grafik.Series[2].ChartType = SeriesChartType.Area;
                    crt_grafik.Series[0].BorderColor = Color.MediumPurple;
                    crt_grafik.Series[0].ChartType = SeriesChartType.Area;
                    crt_grafik.Series[1].BorderColor = Color.HotPink;
                    crt_grafik.Series[1].ChartType = SeriesChartType.Area;

                    if (tBox_B.Text != "") // пока в tBox лежит что-то
                        double_mnvo_B = GetValueAB(tBox_B); // вызываем метод, который лепит массив для B
                                                            /////////////////////////////////////////////////////////////////
                    if ((double_mnvo_B != null) && (CheckToU(uint_mnvo_U, double_mnvo_B) == true))
                    {
                        CheckToCoincidence(ref double_mnvo_A, ref double_mnvo_B, /*ref*/ crt_grafik); // нормируем мн-ва и выводим их                           
                                                                                                      //TODO: в чем разница crt_grafik что с ref, что без???
                        for (int i = 1; i < double_mnvo_A.GetLength(0); i += 2)
                        {
                            for (int j = 1; j < double_mnvo_B.GetLength(0); j += 2)
                            {
                                if (double_mnvo_A[i] == double_mnvo_B[j])
                                    // идем по знаменателям А и В сразу! надо, чтобы выводились все нулевые точки!
                                    //crt_grafik.Series[2].Points.AddXY(double_mnvo_A[i], double_mnvo_A[i - 1] * double_mnvo_B[j - 1]);
                                    crt_grafik.Series[2].Points.AddXY(double_mnvo_B[j], double_mnvo_A[i - 1] * double_mnvo_B[j - 1]);
                                //else crt_grafik.Series[2].Points.AddXY(double_mnvo_B[j], 0);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("ОШИБКА! \nПроверьте правильность введенных данных в В.");
                        return;
                    }
                    return;
                }
            }
            else MessageBox.Show("ОШИБКА! \nПроверьте правильность введенных данных.");
        }
        /*******************************************************************************************************************************************************/
        private void tBox_A_TextChanged(object sender, EventArgs e) // для включения кнопки
        {
            if ((tBox_A.Text != "") &&
                (((tBox_B.Text != "") && (tBox_B.Visible == true))
                || (tBox_B.Visible == false))) // если все, что надо заполнено
                btn_debug.Enabled = true;
            else btn_debug.Enabled = false;
        }
        private void tBox_B_TextChanged(object sender, EventArgs e) // для включения кнопки
        {
            tBox_A_TextChanged(sender, e);
        }

        private void radioButton0_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void crt_grafik_Click(object sender, EventArgs e)
        {

        }

        private void groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void lbl_B_or_Digit_Click(object sender, EventArgs e)
        {

        }
    }
}
