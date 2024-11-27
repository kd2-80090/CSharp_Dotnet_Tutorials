
using MongoDB.Driver;

namespace CrudOperationWithMongoDB.Model
{
    public class CrudOperationDL : ICrudOperationDL
    {
        private readonly IConfiguration _configuration;

        private readonly MongoClient _mongoClient;

        private readonly IMongoCollection<InsertRecordRequest> _mongoCollection;

        public CrudOperationDL(IConfiguration configuration)
        {
            _configuration = configuration;
            _mongoClient = new MongoClient(_configuration["DatabaseSettings:ConnectionString"]);
            var _MongoDatabase = _mongoClient.GetDatabase(_configuration["DatabaseSettings:DatabaseName"]);
            _mongoCollection = _MongoDatabase.GetCollection<InsertRecordRequest>(_configuration["DatabaseSettings:CollectionName"]);
        }

        public async Task<InsertRecordResponse> InsertRecord(InsertRecordRequest request)
        {
            InsertRecordResponse response = new InsertRecordResponse();
            response.IsSuccess = true;
            response.Message = "Data Successfully Inserted";
            
            try
            {
                request.CreatedDate = DateTime.Now.ToString();
                request.UpdatedDate = DateTime.Now.ToString();

                await _mongoCollection.InsertOneAsync(request);
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Occurs : " + ex.Message;
            }

            return response;
        }

        public async Task<GetAllRecordResponse> GetAllRecord()
        {
            GetAllRecordResponse response = new GetAllRecordResponse();
            response.IsSuccess = true;
            response.Message = "Data Fetched Successfully";
            
            try
            {
                response.data = new List<InsertRecordRequest>();
                response.data = await _mongoCollection.Find( x => true).ToListAsync();
                if(response.data.Count == 0)
                {
                    response.Message = "No Record Found";
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess= false;
                response.Message = "Exception Occurs : " + ex.Message;
            }

            return response;
        }
    }
}
