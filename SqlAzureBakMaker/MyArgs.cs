using PowerArgs;

namespace SqlAzureBakMaker
{
    [ArgExceptionBehavior(ArgExceptionPolicy.StandardExceptionHandling)]
    public class MyArgs
    {
        [ArgRequired(PromptIfMissing = true)]
        public string SourceServer { get; set; }

        [ArgRequired(PromptIfMissing = true)]
        public string SourceUser { get; set; }

        [ArgRequired(PromptIfMissing = true)]
        public string SourcePassword { get; set; }

        [ArgRequired(PromptIfMissing = true)]
        public string SourceDatabase { get; set; }

        [ArgRequired(PromptIfMissing = true)]
        public string DestinationServer { get; set; }

        [ArgRequired(PromptIfMissing = true)]
        public string DestinationDatabase { get; set; }

        [ArgRequired(PromptIfMissing = true)]
        public string BakPath { get; set; }

        [ArgRequired(PromptIfMissing = true)]
        public string PathToLocalMdf { get; set; }
        //
        [ArgRequired(PromptIfMissing = true)]
        public string DestinationUser { get; set; }

        [ArgRequired(PromptIfMissing = true)]
        public string DestinationPassword { get; set; }

    }
}
