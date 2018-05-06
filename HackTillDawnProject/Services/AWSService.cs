using Amazon;
using Amazon.Kinesis;
using Amazon.KinesisAnalytics;
using Amazon.Rekognition;
using Amazon.Rekognition.Model;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using Amazon.S3;
using Amazon.S3.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HackTillDawnProject.Services
{
    public interface IAWSService
    {
        Task<MemoryStream> GetObjectFromBucket(string object_key);
    }

    public class AWSService : IAWSService
    {
        public AWSService()
        {

        }

        /// <summary>
        /// Will return the Object using AWS S3 .NET Core API
        /// </summary>
        /// <param name="object_key"></param>
        /// <returns></returns>
        public async Task<MemoryStream> GetObjectFromBucket(string object_key)
        {
            var newRegion = RegionEndpoint.GetBySystemName("us-east-1");
            using (var s3client = new AmazonS3Client(newRegion))
            {
                GetObjectRequest request = new GetObjectRequest
                {
                    BucketName = "ourcoolbucket",
                    Key = object_key
                };

                GetObjectResponse response = await s3client.GetObjectAsync(request);
                if (response.ContentLength > 0)
                {
                    MemoryStream result = new MemoryStream();

                    response.ResponseStream.CopyTo(result);
                    return result;
                }
                else return null;
            }
        }

        public async Task Rekognize()
        {
            var newRegion = RegionEndpoint.GetBySystemName("us-east-1");
            using (var rekClient = new AmazonRekognitionClient(newRegion))
            {
                //Amazon.Rekognition.Model.DetectFacesRequest
                string collection_id = "test";

                CreateCollectionRequest request = new CreateCollectionRequest()
                {
                    CollectionId = collection_id
                };

                CreateCollectionResponse response = await rekClient.CreateCollectionAsync(request);

                KinesisVideoStream VidStream = new KinesisVideoStream()
                {
                    Arn = "arn:aws:kinesisvideo:us-east-1:229551089657:stream/myVideoStream/1525622803413"
                };
                
                StreamProcessorInput SPInput = new StreamProcessorInput()
                {
                    KinesisVideoStream = VidStream
                };
                KinesisDataStream DataStream = new KinesisDataStream()
                {
                    Arn = "arn:aws:kinesis:us-east-1:229551089657:stream/myDataStream"
                };
                StreamProcessorOutput output = new StreamProcessorOutput()
                {
                    KinesisDataStream = DataStream
                };
                FaceSearchSettings faceSearchSettings = new FaceSearchSettings()
                {
                    CollectionId = collection_id,
                    FaceMatchThreshold = 10
                };
                StreamProcessorSettings spSettings = new StreamProcessorSettings()
                {
                    FaceSearch = faceSearchSettings
                };

                CreateStreamProcessorResponse final_resp = await rekClient.CreateStreamProcessorAsync(new CreateStreamProcessorRequest()
                {
                    Input = SPInput,
                    RoleArn = "arn:aws:iam::229551089657:role/RekRole2",
                    Output = output,
                    Settings = spSettings,
                    Name = "CrazyDemo1"
                });

                

                string why = final_resp.StreamProcessorArn;
                 

            }
        }
    }
}
