namespace VLU231_71SEOO30074_03.src.BUS
{
    internal class Result<T>
    {
        public T Value { get; }
        public Error Error { get; }

        private Result(T Value, Error Error)
        {
            this.Value = Value;
            this.Error = Error;
        }

        public static Result<T> Success(T Value)
        {
            return new Result<T>(Value, null);
        }

        public static Result<T> Failure(string Message)
        {
            return new Result<T>(default, Error.New(Message));
        }

        public static Result<T> Failure(Error error)
        {
            return new Result<T>(default, error);
        }

        public bool IsError()
        {
            return Error != null;
        }
    }

    internal class Error
    {
        public string Message { get; }

        private Error(string message)
        {
            Message = message;
        }

        public static Error New(string message)
        {
            return new Error(message);
        }
    }
}
