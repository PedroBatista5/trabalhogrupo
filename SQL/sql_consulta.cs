﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trabalhogrupo.Construtor;

namespace trabalhogrupo.SQL
{
    internal class sql_consulta
    {
        public void AdicionarConsulta(c_consulta obj)
        {

            string sql = @"INSERT INTO mydb.tb_consulta (
        id_animal, 
        nome_medico, 
        tipo_consulta, 
        data_consulta, 
        prox_visita, 
        diagnostico, 
        ato_medico, 
        observacoes, 
        peso,
        prescricao_medica
    ) 
    VALUES (
        @id_animal,
        @nome_medico,
        @tipo_consulta,
        @data_consulta,
        @prox_visita,
        @diagnostico,
        @ato_medico,
        @observacoes,
        @peso,
        @prescricao_medica
    )";

            try
            {
                using (var ligabd = new MySqlConnection(conexao.strligar))
                {
                    ligabd.Open();
                    using (var ligacao = new MySqlCommand(sql, ligabd))
                    {
                        ligacao.Parameters.AddWithValue("@id_animal", obj.id_animal);
                        ligacao.Parameters.AddWithValue("@nome_medico", obj.nome_medico);
                        ligacao.Parameters.AddWithValue("@tipo_consulta", obj.tipo_consulta);
                        ligacao.Parameters.AddWithValue("@data_consulta", obj.data_consulta);
                        ligacao.Parameters.AddWithValue("@prox_visita", obj.prox_visita);
                        ligacao.Parameters.AddWithValue("@diagnostico", obj.diagnostico);
                        ligacao.Parameters.AddWithValue("@ato_medico", obj.ato_medico);
                        ligacao.Parameters.AddWithValue("@observacoes", obj.observacoes);
                        ligacao.Parameters.AddWithValue("@peso", obj.peso);
                        ligacao.Parameters.AddWithValue("@prescricao_medica", obj.prescricao_medica);

                        ligacao.ExecuteNonQuery();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static DataTable GetConsulta()
        {
            var dt = new DataTable(); // Cria uma nova datatable 

            var query = "SELECT * FROM mydb.tb_consulta";

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
        public void DelConsulta(int id_consulta) //Função para deletar TODOS os valores de um id especifico
        {
            var query = "DELETE FROM mydb.tb_consulta WHERE id_consulta= '" + id_consulta + "'";
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
        public void EditarConsulta(int id_consulta, c_consulta obj)
        {
            string query = "UPDATE mydb.tb_consulta SET " +
                           "id_animal = @id_animal, " +
                           "nome_medico = @nome_medico, " +
                           "tipo_consulta = @tipo_consulta, " +
                           "data_consulta = @data_consulta, " +
                           "prox_visita = @prox_visita, " +
                           "diagnostico = @diagnostico, " +
                           "ato_medico = @ato_medico, " +
                           "observacoes = @observacoes, " +
                           "peso = @peso, " +
                           "prescricao_medica = @prescricao_medica " +
                           "WHERE id_consulta = @id_consulta";

            try
            {
                using (var ligabd = new MySqlConnection(conexao.strligar))
                {
                    ligabd.Open();
                    using (var ligacao = new MySqlCommand(query, ligabd))
                    {
                        ligacao.Parameters.AddWithValue("@id_animal", obj.id_animal);
                        ligacao.Parameters.AddWithValue("@nome_medico", obj.nome_medico);
                        ligacao.Parameters.AddWithValue("@tipo_consulta", obj.tipo_consulta);
                        ligacao.Parameters.AddWithValue("@data_consulta", obj.data_consulta);
                        ligacao.Parameters.AddWithValue("@prox_visita", obj.prox_visita);
                        ligacao.Parameters.AddWithValue("@diagnostico", obj.diagnostico);
                        ligacao.Parameters.AddWithValue("@ato_medico", obj.ato_medico);
                        ligacao.Parameters.AddWithValue("@observacoes", obj.observacoes);
                        ligacao.Parameters.AddWithValue("@peso", obj.peso);
                        ligacao.Parameters.AddWithValue("@prescricao_medica", obj.prescricao_medica);
                        ligacao.Parameters.AddWithValue("@id_consulta", id_consulta);

                        ligacao.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Mensagem de erro
            }
        }
        public c_consulta ObterConsultaPorID(int id)
        {
            c_consulta consulta = new c_consulta();

            string sql = "SELECT * FROM mydb.tb_consulta WHERE id_consulta = @id";

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
                                consulta.id_animal = Convert.ToInt32(reader["id_animal"]);
                                consulta.nome_medico = reader["nome_medico"].ToString();
                                consulta.tipo_consulta = reader["tipo_consulta"].ToString();
                                consulta.data_consulta = Convert.ToDateTime(reader["data_consulta"]);
                                consulta.prox_visita = Convert.ToDateTime(reader["prox_visita"]);
                                consulta.diagnostico = reader["diagnostico"].ToString();
                                consulta.ato_medico = reader["ato_medico"].ToString();
                                consulta.observacoes = reader["observacoes"].ToString();
                                consulta.peso = Convert.ToDouble(reader["peso"]);
                                consulta.prescricao_medica = reader["prescricao_medica"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return consulta;
        }

    }
}
