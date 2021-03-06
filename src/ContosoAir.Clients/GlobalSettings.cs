﻿using System;

namespace ContosoAir.Clients
{
    public static class GlobalSettings
    {
        public const string ContosoAirEndpoint = "https://contosoairprod-api-mtczerocfa.azurewebsites.net/";
        public const string AuthenticationTokenEndpoint = "https://api.cognitive.microsoft.com/sts/v1.0";
        public const string SpeechRecognitionEndpoint = "https://speech.platform.bing.com/recognize";

        public const string SkypeBotAccount = "28:d38b16ab-1762-4914-9aeb-c0bcaf411e38";
        public const string FacebookBotAccountAndroid = "fb-messenger://user/";
        public const string FacebookBotAccount = "fb-messenger-public://user-thread/";
        public const string FacebookBotAccountId = "260313431102859";
        public const string CognitiveServicesKey = "8475871faed346eda4abc75ae27dd88d";
        public const string BingSpeechApiKey = "e4d4520cc2d1442d89debbbb1d9909e0";
        public const string AudioContentType = @"audio/wav; codec=""audio/pcm""; samplerate=16000";
        public const string AudioFilename = "ContosoAir.wav";
        public const int DefaultDelayedTime = 20; // in seconds
        public const int DefaultFeedbackTime = 120; // in seconds

        // Default DateTime in views
        public static readonly DateTime MyTripsDepartDate = new DateTime(2017, 4, 4);

        // Azure B2C settings
        public const string ClientId = "8db29c10-50c7-416f-b1c9-795c9592ab4e";
        public static string Authority = "https://login.microsoftonline.com/";
        public const string Tenant = "onemtcb2c.onmicrosoft.com";
        public const string SignUpSignInPolicy = "B2C_1_Contosoair";

        // Azure Push Notification
        //public const string NotificationHubConnectionString = "Endpoint=sb://contosoairprod-notification-nsmtczerocfa.servicebus.windows.net/;SharedAccessKeyName=DefaultListenSharedAccessSignature;SharedAccessKey=ggKKtrwjK1rQHxv06FMUh/moZSUjbn1BsZEWMJfC5iA=";
        //public const string NotificationHubName = "contosoairprodnotification-hub";

        public const string NotificationHubConnectionString = "Endpoint=sb://c2ctushar-namespace.servicebus.windows.net/;SharedAccessKeyName=DefaultListenSharedAccessSignature;SharedAccessKey=LX88dQCC3i9ThgcYXCUPNsFarzlb5HeUVGEqMGXmYN8=";
        public const string NotificationHubName = "c2ctushar-hub";


        // HockeyApp
        public const string HockeyAppiOS = "c5564727a8d94d99b6e8e51505842fd8";
        public const string HockeyAppAndroid = "a24b7677201a48a38f9ad1e0eec7fc90";
        public const string HockeyAppUWP = "89e906b5e04e43d396971aa9e6d4361f";

        // Android
        public const string AndroidProjectNumber = "";
        public const string AndroidPackageId = "com.contoso.air";

        // For fetching details of solo service providers
        public const string GetSoloServiceInfoUrl = "https://c2ctusharfucntions.azurewebsites.net/api/GetSoloServiceProviders?code=pMWMpQabFDFacQMQH9n51eGwXSVJHAYriaqjDJc/MKm1eczDm/0YuA==";
        public const string GetSoloServiceReviewUrl = "https://prod-53.westus.logic.azure.com:443/workflows/941dee7eccb041afbc0173c49f3fcd76/triggers/manual/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=pwDVFdoxy8H9N5DqYvUbDaIFdxPWi50qTe3NrvCP1jA";        
    }
}

