using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trabalhogrupo.Construtor;
using trabalhogrupo.Forms;


namespace trabalhogrupo.SQL
{
    internal class sql_animal
    {
        public static DataTable GetAnimal() 
        {
            var dt = new DataTable(); // Cria uma nova datatable 

            var query = "SELECT * FROM mydb.tb_animal"; 

            try
            {
                using (var ligabd = new MySqlConnection(conexao.strligar))
                {
                    ligabd.Open();
                    using (var ligacao = new MySqlDataAdapter(query, ligabd))
                    {
                        ligacao.Fill(dt); // Preenche a variavel dt com todos os valores selecionados através do comando do MYSQL (query)
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Messagem de Erro
            }

            return dt; // Retorna a datatable
        }

        public void CadastrarAnimal(c_animal obj)
        {

            string sql = @"INSERT INTO mydb.tb_animal (
        nome_dono, 
        contacto_dono, 
        data_nascimento, 
        data_ultima_consulta, 
        tipo_animal, 
        raça, 
        sexo, 
        peso
    ) 
    VALUES (
        @nome_dono,
        @contacto_dono,
        @data_nascimento,
        @data_ultima_consulta,
        @tipo_animal,
        @raça,
        @sexo,
        @peso
    )";


            try
            {
                using (var ligabd = new MySqlConnection(conexao.strligar))
                {
                    ligabd.Open();
                    using (var ligacao = new MySqlCommand(sql, ligabd))
                    {
                        ligacao.Parameters.AddWithValue("@nome_dono", obj.nome_dono);
                        ligacao.Parameters.AddWithValue("@contacto_dono", obj.contacto_dono);
                        ligacao.Parameters.AddWithValue("@data_nascimento", obj.data_nascimento);
                        ligacao.Parameters.AddWithValue("@data_ultima_consulta", obj.data_ultima_consulta);
                        ligacao.Parameters.AddWithValue("@tipo_animal", obj.tipo_animal);
                        ligacao.Parameters.AddWithValue("@raça", obj.raça);
                        ligacao.Parameters.AddWithValue("@sexo", obj.sexo);
                        ligacao.Parameters.AddWithValue("@peso", obj.peso);
                        ligacao.ExecuteNonQuery();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DelAnimal(int id_animal) //Função para deletar TODOS os valores de um id especifico
        {
            var query = "DELETE FROM mydb.tb_animal WHERE id_animal= '" + id_animal + "'";
            try 
            {
                using (var ligabd = new MySqlConnection(conexao.strligar))
                {
                    ligabd.Open();
                    using (var ligacao = new MySqlCommand(query, ligabd))
                    {
                        ligacao.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void EditarAnimal(int id_animal, c_animal obj)
        {
            string query = "UPDATE mydb.tb_animal SET " +
                           "nome_dono = @nome_dono, " +
                           "contacto_dono = @contacto_dono, " +
                           "data_nascimento = @data_nascimento, " +
                           "data_ultima_consulta = @data_ultima_consulta, " +
                           "tipo_animal = @tipo_animal, " +
                           "raça = @raça, " +
                           "sexo = @sexo, " +
                           "peso = @peso " +
                           "WHERE id_animal = @id_animal";

            try
            {
                using (var ligabd = new MySqlConnection(conexao.strligar))
                {
                    ligabd.Open();
                    using (var ligacao = new MySqlCommand(query, ligabd))
                    {
                        ligacao.Parameters.AddWithValue("@nome_dono", obj.nome_dono);
                        ligacao.Parameters.AddWithValue("@contacto_dono", obj.contacto_dono);
                        ligacao.Parameters.AddWithValue("@data_nascimento", obj.data_nascimento);
                        ligacao.Parameters.AddWithValue("@data_ultima_consulta", obj.data_ultima_consulta);
                        ligacao.Parameters.AddWithValue("@tipo_animal", obj.tipo_animal);
                        ligacao.Parameters.AddWithValue("@raça", obj.raça);
                        ligacao.Parameters.AddWithValue("@sexo", obj.sexo);
                        ligacao.Parameters.AddWithValue("@peso", obj.peso);
                        ligacao.Parameters.AddWithValue("@id_animal", id_animal);

                        ligacao.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Mensagem de erro
            }
        }
        public c_animal ObterAnimalPorID(int id)
        {
            c_animal animal = new c_animal();

            string sql = "SELECT * FROM mydb.tb_animal WHERE id_animal = @id";

            try
            {
                using (var ligabd = new MySqlConnection(conexao.strligar))
                {
                    ligabd.Open();
                    using (var ligacao = new MySqlCommand(sql, ligabd))
                    {
                        ligacao.Parameters.AddWithValue("@id", id);
                        using (MySqlDataReader reader = ligacao.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                animal.nome_dono = reader["nome_dono"].ToString();
                                animal.contacto_dono = reader["contacto_dono"].ToString();
                                animal.data_nascimento = Convert.ToDateTime(reader["data_nascimento"]);
                                animal.data_ultima_consulta = Convert.ToDateTime(reader["data_ultima_consulta"]);
                                animal.tipo_animal = reader["tipo_animal"].ToString();
                                animal.raça = reader["raça"].ToString();
                                animal.sexo = reader["sexo"].ToString();
                                animal.peso = Convert.ToDouble(reader["peso"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return animal;
        }


    }
}
