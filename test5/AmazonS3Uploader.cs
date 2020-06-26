using System;
using Amazon.S3;
using Amazon.S3.Model;

namespace test5
{
    public class AmazonS3Uploader
    {
        private string bucketName = "testbucketcscnew1";
        private string keyName = "barot";
        private string filePath = "D:\\images\\Barot_Bellingham_tn.jpg";

        public void UploadFile()
        {
            var client = new AmazonS3Client(Amazon.RegionEndpoint.USEast1);

            try
            {
                PutObjectRequest putRequest = new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = keyName,
                    FilePath = filePath,
                    ContentType = "text/plain"
                };

                PutObjectResponse response = client.PutObject(putRequest);
            }
            catch (AmazonS3Exception amazonS3Exception)
            {
                if (amazonS3Exception.ErrorCode != null &&
                    (amazonS3Exception.ErrorCode.Equals("InvalidAccessKeyId")
                    ||
                    amazonS3Exception.ErrorCode.Equals("InvalidSecurity")))
                {
                    throw new Exception("Check the provided AWS Credentials.");
                }
                else
                {
                    throw new Exception("Error occurred: " + amazonS3Exception.Message);
                }
            }
        }
    }
}