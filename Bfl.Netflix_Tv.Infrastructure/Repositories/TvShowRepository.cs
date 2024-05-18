using Bfl.Netflix_Tv.Core.Configurations;
using Bfl.Netflix_Tv.Core.Domain.Entities;
using Bfl.Netflix_Tv.Core.Domain.RepositoryContracts;
using Bfl.Netflix_Tv.Core.DTO.Shared;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Tv.Infrastructure.Repositories
{
    public class TvShowRepository :  ITvShowsRepository
    {
        
        public TvShowRepository() 
        {
           
        }

        public async Task<TvShow> AddAsync(TvShow entity)
        {
            entity.TvShowId=Guid.NewGuid();
            using(SqlConnection connection=new SqlConnection(Configuration.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(TvShowConfiguration.InsertSP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@"+TvShowConfiguration.TvShowId,entity.TvShowId);
                    command.Parameters.AddWithValue("@" + TvShowConfiguration.TvShowName,entity.TvShowName);
                    command.Parameters.AddWithValue("@" + TvShowConfiguration.Seasons, entity.Seasons);
                    command.Parameters.AddWithValue("@" + TvShowConfiguration.Description, entity.Description);
                    command.Parameters.AddWithValue("@" + TvShowConfiguration.CreatorName, entity.CreatorName);
                    command.Parameters.AddWithValue("@" + TvShowConfiguration.Language, entity.Language);
                    command.Parameters.AddWithValue("@" + TvShowConfiguration.ImagePath,"-");
                    command.Parameters.AddWithValue("@" + TvShowConfiguration.Rating, entity.Rating);
                    command.Parameters.AddWithValue("@" + TvShowConfiguration.TrailerPath,"_");
                    command.Parameters.AddWithValue("@" + TvShowConfiguration.ReleaseDate, entity.ReleaseDate);
                    command.Parameters.AddWithValue("@" + TvShowConfiguration.Access, entity.Access);

                    await  connection.OpenAsync();
                   int a=await command.ExecuteNonQueryAsync();

                    if (a > 0)
                        return entity;
                    throw new Error("Something went wrong while Saving TvShow Details");
                }
            }
               
        }

        public async Task DeleteAsync(Guid id)
        {
            using(SqlConnection connection=new SqlConnection(Configuration.ConnectionString))
            {
                using(SqlCommand command=new SqlCommand(TvShowConfiguration.DeleteSP, connection))
                {
                    command.CommandType=CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@"+TvShowConfiguration.TvShowId, id);
                   
                    await connection.OpenAsync();
                  var response=await command.ExecuteNonQueryAsync();
                    
                }
            }
        }

        public Task<bool> Exists(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TvShow>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<TvShow> GetAsync(Guid id)
        {
            TvShow tv=null;
            using(SqlConnection connection=new SqlConnection(Configuration.ConnectionString))
            {
                using(SqlCommand command=new SqlCommand(TvShowConfiguration.GetSP,connection))
                {
                    command.CommandType=CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@"+TvShowConfiguration.TvShowId, id);
                    await connection.OpenAsync();
                    using(SqlDataReader reader=command.ExecuteReader())
                    {
                        while(await reader.ReadAsync())
                        {
                            tv = new TvShow();
                            tv.TvShowId = (Guid)reader[TvShowConfiguration.TvShowId];
                            tv.TvShowName = (string)reader[TvShowConfiguration.TvShowName];
                            tv.Seasons=(int)reader[TvShowConfiguration.Seasons];
                            tv.Description = (string)reader[TvShowConfiguration.Description];
                            tv.CreatorName = (string)reader[TvShowConfiguration.CreatorName];
                            tv.Language = (string)reader[TvShowConfiguration.Language];
                            tv.ReleaseDate = (DateTime)reader[TvShowConfiguration.ReleaseDate];
                            tv.ImagePath=(string)reader[TvShowConfiguration.ImagePath];
                            tv.TrailerPath = (string)reader[TvShowConfiguration.TrailerPath];
                            tv.Rating = (double)reader[TvShowConfiguration.Rating];
                            tv.Access = (string)reader[TvShowConfiguration.Access];
                        }
                        if(tv != null)
                        {
                            return tv;
                        }
                        throw new Error("TvShow doesn't exist with given id");

                    }
                }
            }
        }

        public Task UpdateAsync(TvShow entity)
        {
            throw new NotImplementedException();
        }
    }
}
