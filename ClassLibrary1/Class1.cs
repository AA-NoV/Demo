namespace ClassLibrary1
{
    /// <summary>
    /// Заявка на ремонт.
    /// </summary>
    public class RequestRemont
    {
        public int ID { get; private set; }
        public string Equipment { get; private set; }
        public string SerialNumber { get; private set; }
        public string Description { get; private set; }
        public int ClientId { get; private set; }
        public string Priority { get; private set; }
        public DateTime CreateAt { get; private set; }
        public DateTime UpdateAt { get; private set; }
        public DateTime FinishAt { get; private set; }
        public string Status { get; private set; }
        /// <summary>
        /// Атрибуты заявки.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ClienId"></param>
        public RequestRemont(int id, int ClienId)
        {
            ID = id;
            Equipment = string.Empty;
            SerialNumber = string.Empty;
            Description = string.Empty;
            ClientId = ClienId;
            Priority = string.Empty;
            CreateAt = DateTime.MinValue;
            UpdateAt = DateTime.Now;
            FinishAt = DateTime.MaxValue;
            Status = string.Empty;
        }
    }
    /// <summary>
    /// Регистрация заявки.
    /// </summary>
    public class RequestRegistary
    {
        public int Id { get; private set; }
        public string Info { get; private set; }
        public string Priority { get; private set; }
        public string Login { get; private set; }
        public string Password { get; private set; }
        /// <summary>
        /// Атрибуты регистрации.
        /// </summary>
        /// <param name="id"></param>
        public RequestRegistary(int id)
        {
            Id = id;
            Info = string.Empty;
            Priority = string.Empty;
            Login = string.Empty;
            Password = string.Empty;
        }
    }
    /// <summary>
    /// Обработка заявки.
    /// </summary>
    public class RequestProcessor
    {
        public int Id { get; private set; }
        public string Analise { get; private set; }
        public string Priority { get; private set;}
        public int ExecutorId { get; private set; }
        /// <summary>
        /// Атрибуты обработки.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ExecutorId"></param>
        public RequestProcessor(int id, int ExecutorId)
        {
            Id = id;
            Analise = string.Empty;
            Priority = string.Empty;
            ExecutorId = ExecutorId;
        }
    }
    /// <summary>
    /// Исполнение заявки.
    /// </summary>
    public class RequestExecute
    {
        public int Id { get; private set; }
        public int ExecutorId { get; private set; }
        public string NeededChange { get; private set; }
        public string PartOrder { get; private set; }
        /// <summary>
        /// Атрибуты исполнения.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ExecutorId"></param>
        public RequestExecute(int id, int ExecutorId)
        {
            Id = id;
            ExecutorId = ExecutorId;
            NeededChange = string.Empty;
            PartOrder = string.Empty;
        }
    }
    /// <summary>
    /// Отчетность.
    /// </summary>
    public class Report
    {
        public int Id { get; private set; }
        public DateTime StartAt { get; private set; }
        public DateTime FinishAt { get; private set; }
        public string Materials { get; private set; }
        public double Cost { get; private set; }
        public string TroubleCause { get; private set; }
        public string Assist {  get; private set; }
        /// <summary>
        /// Атрибуты отчетности.
        /// </summary>
        /// <param name="id"></param>
        public Report(int id)
        {
            Id = id;
            StartAt = DateTime.MinValue;
            FinishAt = DateTime.MaxValue;
            Materials = string.Empty;
            Cost = 0;
            TroubleCause = string.Empty;
            Assist = string.Empty;
        }
    }
    /// <summary>
    /// Мониторинг и анализ.
    /// </summary>
    public class Monitoring
    {
        public int Id { get; private set; }
        public DateTime StartAt { get; private set; }
        public DateTime FinishAt { get; private set; }
        public string Quality { get; private set; }
        public string Expenses { get; private set; }
        /// <summary>
        /// Атрибуты мониторинга.
        /// </summary>
        /// <param name="id"></param>
        public Monitoring(int id)
        {
            Id = id;
            StartAt = DateTime.MinValue;
            FinishAt = DateTime.MaxValue;
            Quality = string.Empty;
            Expenses = string.Empty;
        }
    }
    /// <summary>
    /// Клиент.
    /// </summary>
    public class Client
    {
        public int Id { get; private set;}
        public string Name { get; private set; }
        public string Lastname { get; private set; }
        public int PhoneNumber { get; private set; }
        /// <summary>
        /// Атрибуты клиента.
        /// </summary>
        /// <param name="id"></param>
        public Client(int id)
        {
            Id = id;
            Name = string.Empty;
            Lastname = string.Empty;
            PhoneNumber = 0;
        }
    }
    /// <summary>
    /// Исполнитель.
    /// </summary>
    public class Executor
    {
        public int Id { get; private set;}
        public string Name { get; private set; }
        public string Lastname { get; private set; }
        /// <summary>
        /// Атрибуты исполнителя.
        /// </summary>
        /// <param name="id"></param>
        public Executor(int id)
        {
            Id = id;
            Name = string.Empty;
            Lastname = string.Empty;
        }
    }
}
