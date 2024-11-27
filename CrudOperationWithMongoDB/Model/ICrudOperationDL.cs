namespace CrudOperationWithMongoDB.Model
{
    public interface ICrudOperationDL
    {
        public Task<InsertRecordResponse> InsertRecord(InsertRecordRequest request);

        public Task<GetAllRecordResponse> GetAllRecord();
    }
}
