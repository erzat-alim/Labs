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
using MySql.Data.MySqlClient;

namespace PM._03
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            this.Style = MetroFramework.MetroColorStyle.Orange;
            refresh();
        }

        void refresh()
        {
            // Здесь можно добавить начальную загрузку данных
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[textBoxSort.Text], ListSortDirection.Ascending);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            switch (PM._03.Properties.Settings.Default.l)
            {
                case 1:
                    MySqlConnection connection = new MySqlConnection
                        ("server=localhost; database=magazin_avtozapchastey; uid=root; pwd=; charset=utf8;");
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter
                        ("select sklad.id_sklad, detali.name as 'Наименование_детали', " +
                        "yacheika.nomer as 'Ячейка', sklad.ostatok from sklad " +
                        "inner join detali on sklad.id_detal = detali.id_detal " +
                        "inner join yacheika on sklad.id_yacheika = yacheika.id_yacheika " +
                        "where detali.name like '%" + textBoxSearch.Text + "%' " +
                        "or yacheika.nomer like '%" + textBoxSearch.Text + "%' " +
                        "or sklad.ostatok like '%" + textBoxSearch.Text + "%'", connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                    dataGridView1.Columns[0].Visible = false;
                    connection.Close();
                    break;

                case 2:
                    MySqlConnection connection2 = new MySqlConnection
                        ("server=localhost; database=magazin_avtozapchastey; uid=root; pwd=; charset=utf8;");
                    connection2.Open();
                    MySqlDataAdapter adapter2 = new MySqlDataAdapter
                        ("select klients.id_klient, klients.f_klient as 'Фамилия', klients.i_klient as 'Имя', " +
                        "klients.o_klient as 'Отчество', klients.data_rozhdeniya as 'Дата_рождения', " +
                        "klients.telephone as 'Телефон', klients.address as 'Адрес', " +
                        "gorod_klienta.gorod as 'Город' from klients " +
                        "inner join gorod_klienta on klients.id_gorod_klienta = gorod_klienta.id_gorod_klienta " +
                        "where klients.f_klient like '%" + textBoxSearch.Text + "%' " +
                        "or klients.i_klient like '%" + textBoxSearch.Text + "%' " +
                        "or klients.o_klient like '%" + textBoxSearch.Text + "%' " +
                        "or klients.data_rozhdeniya like '%" + textBoxSearch.Text + "%' " +
                        "or klients.telephone like '%" + textBoxSearch.Text + "%' " +
                        "or klients.address like '%" + textBoxSearch.Text + "%' " +
                        "or gorod_klienta.gorod like '%" + textBoxSearch.Text + "%'", connection2);
                    DataTable table2 = new DataTable();
                    adapter2.Fill(table2);
                    dataGridView1.DataSource = table2;
                    dataGridView1.Columns[0].Visible = false;
                    connection2.Close();
                    break;

                case 3:
                    MySqlConnection connection3 = new MySqlConnection
                        ("server=localhost; database=magazin_avtozapchastey; uid=root; pwd=; charset=utf8;");
                    connection3.Open();
                    MySqlDataAdapter adapter3 = new MySqlDataAdapter
                        ("select postavschiki.id_postavschik, postavschiki.name as 'Название', " +
                        "postavschiki.telephone as 'Телефон', kategoriya_postavschika.kategoriya as 'Категория', " +
                        "strana_postavschika.strana as 'Страна', postavschiki.address as 'Адрес' from postavschiki " +
                        "inner join kategoriya_postavschika on postavschiki.id_kategoriya_postavschika = kategoriya_postavschika.id_kategoriya_postavschika " +
                        "inner join strana_postavschika on postavschiki.id_strana_postavschika = strana_postavschika.id_strana_postavschika " +
                        "where postavschiki.name like '%" + textBoxSearch.Text + "%' " +
                        "or postavschiki.telephone like '%" + textBoxSearch.Text + "%' " +
                        "or kategoriya_postavschika.kategoriya like '%" + textBoxSearch.Text + "%' " +
                        "or strana_postavschika.strana like '%" + textBoxSearch.Text + "%' " +
                        "or postavschiki.address like '%" + textBoxSearch.Text + "%'", connection3);
                    DataTable table3 = new DataTable();
                    adapter3.Fill(table3);
                    dataGridView1.DataSource = table3;
                    dataGridView1.Columns[0].Visible = false;
                    connection3.Close();
                    break;

                case 4:
                    MySqlConnection connection4 = new MySqlConnection
                        ("server=localhost; database=magazin_avtozapchastey; uid=root; pwd=; charset=utf8;");
                    connection4.Open();
                    MySqlDataAdapter adapter4 = new MySqlDataAdapter
                        ("select detali.id_detal, detali.name as 'Название', detali.info as 'Описание', " +
                        "detali.isena_postavka as 'Цена_поставки', detali.isena_prodazha as 'Цена_продажи', " +
                        "firma_proizvoditel.name as 'Производитель' from detali " +
                        "inner join firma_proizvoditel on detali.id_firma_proizvoditel = firma_proizvoditel.id_firma_proizvoditel " +
                        "where detali.name like '%" + textBoxSearch.Text + "%' " +
                        "or detali.info like '%" + textBoxSearch.Text + "%' " +
                        "or detali.isena_postavka like '%" + textBoxSearch.Text + "%' " +
                        "or detali.isena_prodazha like '%" + textBoxSearch.Text + "%' " +
                        "or firma_proizvoditel.name like '%" + textBoxSearch.Text + "%'", connection4);
                    DataTable table4 = new DataTable();
                    adapter4.Fill(table4);
                    dataGridView1.DataSource = table4;
                    dataGridView1.Columns[0].Visible = false;
                    connection4.Close();
                    break;

                case 5:
                    MySqlConnection connection5 = new MySqlConnection
                        ("server=localhost; database=magazin_avtozapchastey; uid=root; pwd=; charset=utf8;");
                    connection5.Open();
                    MySqlDataAdapter adapter5 = new MySqlDataAdapter
                        ("select postavka.id_postavka, detali.name as 'Деталь', postavka.kolichestvo as 'Количество', " +
                        "postavka.summa as 'Сумма', postavka.garantiya as 'Гарантия', postavschiki.name as 'Поставщик', " +
                        "postavka.data_postavki as 'Дата_поставки' from postavka " +
                        "inner join detali on postavka.id_detal = detali.id_detal " +
                        "inner join postavschiki on postavka.id_postavschik = postavschiki.id_postavschik " +
                        "where detali.name like '%" + textBoxSearch.Text + "%' " +
                        "or postavka.kolichestvo like '%" + textBoxSearch.Text + "%' " +
                        "or postavka.summa like '%" + textBoxSearch.Text + "%' " +
                        "or postavka.garantiya like '%" + textBoxSearch.Text + "%' " +
                        "or postavschiki.name like '%" + textBoxSearch.Text + "%' " +
                        "or postavka.data_postavki like '%" + textBoxSearch.Text + "%'", connection5);
                    DataTable table5 = new DataTable();
                    adapter5.Fill(table5);
                    dataGridView1.DataSource = table5;
                    dataGridView1.Columns[0].Visible = false;
                    connection5.Close();
                    break;

                case 6:
                    MySqlConnection connection6 = new MySqlConnection
                        ("server=localhost; database=magazin_avtozapchastey; uid=root; pwd=; charset=utf8;");
                    connection6.Open();
                    MySqlDataAdapter adapter6 = new MySqlDataAdapter
                        ("select prodazha.id_prodazha, detali.name as 'Товар', prodazha.kolichestvo as 'Количество', " +
                        "prodazha.summa as 'Сумма', concat(klients.f_klient, ' ', klients.i_klient, ' ', klients.o_klient) as 'Клиент', " +
                        "prodazha.data_prodazhi as 'Дата_продажи' from prodazha " +
                        "inner join detali on prodazha.id_detal = detali.id_detal " +
                        "inner join klients on prodazha.id_klient = klients.id_klient " +
                        "where detali.name like '%" + textBoxSearch.Text + "%' " +
                        "or prodazha.kolichestvo like '%" + textBoxSearch.Text + "%' " +
                        "or prodazha.summa like '%" + textBoxSearch.Text + "%' " +
                        "or klients.f_klient like '%" + textBoxSearch.Text + "%' " +
                        "or klients.i_klient like '%" + textBoxSearch.Text + "%' " +
                        "or klients.o_klient like '%" + textBoxSearch.Text + "%' " +
                        "or prodazha.data_prodazhi like '%" + textBoxSearch.Text + "%'", connection6);
                    DataTable table6 = new DataTable();
                    adapter6.Fill(table6);
                    dataGridView1.DataSource = table6;
                    dataGridView1.Columns[0].Visible = false;
                    connection6.Close();
                    break;

                case 7:
                    MySqlConnection connection7 = new MySqlConnection
                        ("server=localhost; database=magazin_avtozapchastey; uid=root; pwd=; charset=utf8;");
                    connection7.Open();
                    MySqlDataAdapter adapter7 = new MySqlDataAdapter
                        ("select brak.id_brak, brak.kolichestvo as 'Количество', brak.summa_vozvrata as 'Сумма_возврата', " +
                        "detali.name as 'Товар', brak.data_vozvrata as 'Дата_возврата' from brak " +
                        "inner join postavka on brak.id_postavka = postavka.id_postavka " +
                        "inner join detali on postavka.id_detal = detali.id_detal " +
                        "where brak.kolichestvo like '%" + textBoxSearch.Text + "%' " +
                        "or brak.summa_vozvrata like '%" + textBoxSearch.Text + "%' " +
                        "or detali.name like '%" + textBoxSearch.Text + "%' " +
                        "or brak.data_vozvrata like '%" + textBoxSearch.Text + "%'", connection7);
                    DataTable table7 = new DataTable();
                    adapter7.Fill(table7);
                    dataGridView1.DataSource = table7;
                    dataGridView1.Columns[0].Visible = false;
                    connection7.Close();
                    break;

                case 8:
                    MySqlConnection connection8 = new MySqlConnection
                        ("server=localhost; database=magazin_avtozapchastey; uid=root; pwd=; charset=utf8;");
                    connection8.Open();
                    MySqlDataAdapter adapter8 = new MySqlDataAdapter
                        ("select zayavki.id_zayavka, zayavki.nomer as 'Номер_заявки', " +
                        "concat(klients.f_klient, ' ', klients.i_klient, ' ', klients.o_klient) as 'Клиент', " +
                        "detali.name as 'Товар', zayavki.kolichestvo as 'Количество', zayavki.summa as 'Сумма', " +
                        "zayavki.data_zayavki as 'Дата_заявки', zayavki.data_ispolneniya as 'План_исполнения', " +
                        "zayavki.fact_data_ispolneniya as 'Факт_исполнения', " +
                        "zayavki.status_zayavki as 'Статус' from zayavki " +
                        "inner join klients on zayavki.id_klient = klients.id_klient " +
                        "inner join detali on zayavki.id_detal = detali.id_detal " +
                        "where zayavki.nomer like '%" + textBoxSearch.Text + "%' " +
                        "or klients.f_klient like '%" + textBoxSearch.Text + "%' " +
                        "or klients.i_klient like '%" + textBoxSearch.Text + "%' " +
                        "or klients.o_klient like '%" + textBoxSearch.Text + "%' " +
                        "or detali.name like '%" + textBoxSearch.Text + "%' " +
                        "or zayavki.kolichestvo like '%" + textBoxSearch.Text + "%' " +
                        "or zayavki.summa like '%" + textBoxSearch.Text + "%' " +
                        "or zayavki.data_zayavki like '%" + textBoxSearch.Text + "%' " +
                        "or zayavki.data_ispolneniya like '%" + textBoxSearch.Text + "%' " +
                        "or zayavki.fact_data_ispolneniya like '%" + textBoxSearch.Text + "%' " +
                        "or zayavki.status_zayavki like '%" + textBoxSearch.Text + "%'", connection8);
                    DataTable table8 = new DataTable();
                    adapter8.Fill(table8);
                    dataGridView1.DataSource = table8;
                    dataGridView1.Columns[0].Visible = false;
                    connection8.Close();
                    break;

                case 9:
                    MySqlConnection connection9 = new MySqlConnection
                        ("server=localhost; database=magazin_avtozapchastey; uid=root; pwd=; charset=utf8;");
                    connection9.Open();
                    MySqlDataAdapter adapter9 = new MySqlDataAdapter
                        ("select vipiska.id_vipiska, detali.name as 'Товар', vipiska.kolichestvo as 'Количество', " +
                        "vipiska.summa as 'Сумма', vipiska.data_vipiski as 'Дата_выписки' from vipiska " +
                        "inner join detali on vipiska.id_detal = detali.id_detal " +
                        "where detali.name like '%" + textBoxSearch.Text + "%' " +
                        "or vipiska.kolichestvo like '%" + textBoxSearch.Text + "%' " +
                        "or vipiska.summa like '%" + textBoxSearch.Text + "%' " +
                        "or vipiska.data_vipiski like '%" + textBoxSearch.Text + "%'", connection9);
                    DataTable table9 = new DataTable();
                    adapter9.Fill(table9);
                    dataGridView1.DataSource = table9;
                    dataGridView1.Columns[0].Visible = false;
                    connection9.Close();
                    break;
            }
        }
    }
}