-- Tạo database HrmDb
CREATE DATABASE HrmDb;
GO

USE HrmDb;
GO

-- Tạo bảng Phòng ban
CREATE TABLE Department (
    DepartmentId INT IDENTITY(1,1) PRIMARY KEY,
    DepartmentName NVARCHAR(100) NOT NULL,
    Description NVARCHAR(500) NULL,
    CreatedDate DATETIME DEFAULT GETDATE(),
    IsActive BIT DEFAULT 1
);
GO

-- Tạo bảng Chức vụ
CREATE TABLE Position (
    PositionId INT IDENTITY(1,1) PRIMARY KEY,
    PositionName NVARCHAR(100) NOT NULL,
    Description NVARCHAR(500) NULL,
    Allowance DECIMAL(18,2) DEFAULT 0, -- Phụ cấp chức vụ
    CreatedDate DATETIME DEFAULT GETDATE(),
    IsActive BIT DEFAULT 1
);
GO

-- Tạo bảng Trình độ
CREATE TABLE Education (
    EducationId INT IDENTITY(1,1) PRIMARY KEY,
    EducationName NVARCHAR(100) NOT NULL,
    Description NVARCHAR(500) NULL,
    CreatedDate DATETIME DEFAULT GETDATE(),
    IsActive BIT DEFAULT 1
);
GO

-- Tạo bảng Dân tộc
CREATE TABLE Ethnicity (
    EthnicityId INT IDENTITY(1,1) PRIMARY KEY,
    EthnicityName NVARCHAR(100) NOT NULL,
    Description NVARCHAR(500) NULL,
    CreatedDate DATETIME DEFAULT GETDATE(),
    IsActive BIT DEFAULT 1
);
GO

-- Tạo bảng Tôn giáo
CREATE TABLE Religion (
    ReligionId INT IDENTITY(1,1) PRIMARY KEY,
    ReligionName NVARCHAR(100) NOT NULL,
    Description NVARCHAR(500) NULL,
    CreatedDate DATETIME DEFAULT GETDATE(),
    IsActive BIT DEFAULT 1
);
GO

-- Tạo bảng Loại nhân viên (Biên chế/Hợp đồng)
CREATE TABLE EmployeeType (
    EmployeeTypeId INT IDENTITY(1,1) PRIMARY KEY,
    TypeName NVARCHAR(100) NOT NULL,
    Description NVARCHAR(500) NULL,
    CreatedDate DATETIME DEFAULT GETDATE(),
    IsActive BIT DEFAULT 1
);
GO

-- Tạo bảng Bậc lương
CREATE TABLE SalaryGrade (
    SalaryGradeId INT IDENTITY(1,1) PRIMARY KEY,
    GradeName NVARCHAR(100) NOT NULL,
    BasicSalary DECIMAL(18,2) NOT NULL,
    Coefficient DECIMAL(10,2) NOT NULL, -- Hệ số lương
    Description NVARCHAR(500) NULL,
    CreatedDate DATETIME DEFAULT GETDATE(),
    IsActive BIT DEFAULT 1
);
GO

-- Tạo bảng Nhân viên
CREATE TABLE Employee (
    EmployeeId INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeCode NVARCHAR(20) NOT NULL,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    FullName NVARCHAR(100) NOT NULL,
    DateOfBirth DATE NOT NULL,
    Gender NVARCHAR(10) NOT NULL,
    IdentityNumber NVARCHAR(20) NOT NULL, -- CMND/CCCD
    IdentityIssuedDate DATE NULL, -- Ngày cấp
    IdentityIssuedPlace NVARCHAR(100) NULL, -- Nơi cấp
    PermanentAddress NVARCHAR(200) NULL, -- Hộ khẩu thường trú
    TemporaryAddress NVARCHAR(200) NULL, -- Địa chỉ hiện tại
    PhoneNumber NVARCHAR(20) NULL,
    Email NVARCHAR(100) NULL,
    
    EthnicityId INT NULL,
    ReligionId INT NULL,
    EducationId INT NULL,
    EmployeeTypeId INT NOT NULL, -- Biên chế/Hợp đồng
    DepartmentId INT NOT NULL,
    PositionId INT NOT NULL,
    SalaryGradeId INT NOT NULL,
    
    JoinDate DATE NOT NULL, -- Ngày vào cơ quan
    UnionJoinDate DATE NULL, -- Ngày vào đoàn
    PartyJoinDate DATE NULL, -- Ngày vào đảng
    ProbationEndDate DATE NULL, -- Ngày kết thúc thử việc
    ContractEndDate DATE NULL, -- Ngày kết thúc hợp đồng (nếu là HĐ có thời hạn)
    
    MaritalStatus NVARCHAR(50) NULL, -- Tình trạng hôn nhân
    PolicyBeneficiary NVARCHAR(200) NULL, -- Diện chính sách
    InsuranceNumber NVARCHAR(50) NULL, -- Số BHXH
    TaxCode NVARCHAR(20) NULL, -- Mã số thuế
    BankAccount NVARCHAR(50) NULL, -- Số tài khoản ngân hàng
    BankName NVARCHAR(100) NULL, -- Tên ngân hàng
    
    IsActive BIT DEFAULT 1,
    CreatedDate DATETIME DEFAULT GETDATE(),
    CreatedBy INT NULL,
    ModifiedDate DATETIME NULL,
    ModifiedBy INT NULL,
    
    FOREIGN KEY (EthnicityId) REFERENCES Ethnicity(EthnicityId),
    FOREIGN KEY (ReligionId) REFERENCES Religion(ReligionId),
    FOREIGN KEY (EducationId) REFERENCES Education(EducationId),
    FOREIGN KEY (EmployeeTypeId) REFERENCES EmployeeType(EmployeeTypeId),
    FOREIGN KEY (DepartmentId) REFERENCES Department(DepartmentId),
    FOREIGN KEY (PositionId) REFERENCES Position(PositionId),
    FOREIGN KEY (SalaryGradeId) REFERENCES SalaryGrade(SalaryGradeId)
);
GO

-- Tạo bảng Thông tin gia đình
CREATE TABLE FamilyMember (
    FamilyMemberId INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeId INT NOT NULL,
    RelationshipType NVARCHAR(50) NOT NULL, -- Mối quan hệ (Cha, Mẹ, Vợ, Chồng, Con...)
    FullName NVARCHAR(100) NOT NULL,
    DateOfBirth DATE NULL,
    Occupation NVARCHAR(100) NULL,
    Address NVARCHAR(200) NULL,
    PhoneNumber NVARCHAR(20) NULL,
    IsDependent BIT DEFAULT 0, -- Người phụ thuộc (để tính giảm trừ thuế)
    CreatedDate DATETIME DEFAULT GETDATE(),
    
    FOREIGN KEY (EmployeeId) REFERENCES Employee(EmployeeId)
);
GO

-- Tạo bảng Bằng cấp, chứng chỉ
CREATE TABLE Certificate (
    CertificateId INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeId INT NOT NULL,
    CertificateName NVARCHAR(100) NOT NULL,
    Major NVARCHAR(100) NULL, -- Chuyên ngành
    IssuedBy NVARCHAR(200) NOT NULL, -- Nơi cấp
    IssuedDate DATE NOT NULL, -- Ngày cấp
    ExpiryDate DATE NULL, -- Ngày hết hạn (nếu có)
    Description NVARCHAR(500) NULL,
    CreatedDate DATETIME DEFAULT GETDATE(),
    
    FOREIGN KEY (EmployeeId) REFERENCES Employee(EmployeeId)
);
GO

-- Tạo bảng Trình độ ngoại ngữ
CREATE TABLE LanguageProficiency (
    LanguageProficiencyId INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeId INT NOT NULL,
    LanguageName NVARCHAR(50) NOT NULL, -- Tên ngoại ngữ
    Level NVARCHAR(50) NOT NULL, -- Trình độ (A1, A2, B1, B2, C1, C2...)
    CertificateName NVARCHAR(100) NULL, -- Tên chứng chỉ
    IssuedBy NVARCHAR(200) NULL, -- Nơi cấp
    IssuedDate DATE NULL, -- Ngày cấp
    ExpiryDate DATE NULL, -- Ngày hết hạn
    Description NVARCHAR(500) NULL,
    CreatedDate DATETIME DEFAULT GETDATE(),
    
    FOREIGN KEY (EmployeeId) REFERENCES Employee(EmployeeId)
);
GO

-- Tạo bảng Quá trình công tác
CREATE TABLE WorkHistory (
    WorkHistoryId INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeId INT NOT NULL,
    FromDate DATE NOT NULL,
    ToDate DATE NULL,
    DepartmentId INT NULL,
    PositionId INT NULL,
    CompanyName NVARCHAR(200) NULL, -- Nếu là quá trình công tác ở nơi khác
    Description NVARCHAR(500) NULL,
    CreatedDate DATETIME DEFAULT GETDATE(),
    
    FOREIGN KEY (EmployeeId) REFERENCES Employee(EmployeeId),
    FOREIGN KEY (DepartmentId) REFERENCES Department(DepartmentId),
    FOREIGN KEY (PositionId) REFERENCES Position(PositionId)
);
GO

-- Tạo bảng Khen thưởng
CREATE TABLE Reward (
    RewardId INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeId INT NOT NULL,
    RewardDate DATE NOT NULL,
    RewardType NVARCHAR(100) NOT NULL, -- Loại khen thưởng
    Amount DECIMAL(18,2) NULL, -- Tiền thưởng (nếu có)
    Reason NVARCHAR(500) NOT NULL,
    DecisionNumber NVARCHAR(50) NULL, -- Số quyết định
    DecisionDate DATE NULL, -- Ngày quyết định
    DecisionBy NVARCHAR(100) NULL, -- Người ký quyết định
    CreatedDate DATETIME DEFAULT GETDATE(),
    CreatedBy INT NULL,
    
    FOREIGN KEY (EmployeeId) REFERENCES Employee(EmployeeId)
);
GO

-- Tạo bảng Kỷ luật
CREATE TABLE Discipline (
    DisciplineId INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeId INT NOT NULL,
    DisciplineDate DATE NOT NULL,
    DisciplineType NVARCHAR(100) NOT NULL, -- Loại kỷ luật
    Amount DECIMAL(18,2) NULL, -- Tiền phạt (nếu có)
    Reason NVARCHAR(500) NOT NULL,
    DecisionNumber NVARCHAR(50) NULL, -- Số quyết định
    DecisionDate DATE NULL, -- Ngày quyết định
    DecisionBy NVARCHAR(100) NULL, -- Người ký quyết định
    CreatedDate DATETIME DEFAULT GETDATE(),
    CreatedBy INT NULL,
    
    FOREIGN KEY (EmployeeId) REFERENCES Employee(EmployeeId)
);
GO

-- Tạo bảng Tăng lương
CREATE TABLE SalaryIncrement (
    SalaryIncrementId INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeId INT NOT NULL,
    FromDate DATE NOT NULL,
    PreviousSalaryGradeId INT NOT NULL,
    NewSalaryGradeId INT NOT NULL,
    Reason NVARCHAR(500) NOT NULL,
    DecisionNumber NVARCHAR(50) NULL, -- Số quyết định
    DecisionDate DATE NULL, -- Ngày quyết định
    DecisionBy NVARCHAR(100) NULL, -- Người ký quyết định
    CreatedDate DATETIME DEFAULT GETDATE(),
    CreatedBy INT NULL,
    
    FOREIGN KEY (EmployeeId) REFERENCES Employee(EmployeeId),
    FOREIGN KEY (PreviousSalaryGradeId) REFERENCES SalaryGrade(SalaryGradeId),
    FOREIGN KEY (NewSalaryGradeId) REFERENCES SalaryGrade(SalaryGradeId)
);
GO

-- Tạo bảng Chuyển công tác
CREATE TABLE Transfer (
    TransferId INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeId INT NOT NULL,
    TransferDate DATE NOT NULL,
    FromDepartmentId INT NOT NULL,
    ToDepartmentId INT NOT NULL,
    FromPositionId INT NULL,
    ToPositionId INT NULL,
    Reason NVARCHAR(500) NOT NULL,
    DecisionNumber NVARCHAR(50) NULL, -- Số quyết định
    DecisionDate DATE NULL, -- Ngày quyết định
    DecisionBy NVARCHAR(100) NULL, -- Người ký quyết định
    CreatedDate DATETIME DEFAULT GETDATE(),
    CreatedBy INT NULL,
    
    FOREIGN KEY (EmployeeId) REFERENCES Employee(EmployeeId),
    FOREIGN KEY (FromDepartmentId) REFERENCES Department(DepartmentId),
    FOREIGN KEY (ToDepartmentId) REFERENCES Department(DepartmentId),
    FOREIGN KEY (FromPositionId) REFERENCES Position(PositionId),
    FOREIGN KEY (ToPositionId) REFERENCES Position(PositionId)
);
GO

-- Tạo bảng Chấm công
CREATE TABLE Attendance (
    AttendanceId INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeId INT NOT NULL,
    AttendanceDate DATE NOT NULL,
    TimeIn TIME NULL,
    TimeOut TIME NULL,
    Status NVARCHAR(50) NOT NULL, -- Đi làm, Nghỉ phép, Nghỉ ốm, Nghỉ không lương...
    Note NVARCHAR(500) NULL,
    CreatedDate DATETIME DEFAULT GETDATE(),
    CreatedBy INT NULL,
    ModifiedDate DATETIME NULL,
    ModifiedBy INT NULL,
    
    FOREIGN KEY (EmployeeId) REFERENCES Employee(EmployeeId)
);
GO

-- Tạo bảng Phân công công việc
CREATE TABLE Assignment (
    AssignmentId INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeId INT NOT NULL,
    Title NVARCHAR(200) NOT NULL,
    Description NVARCHAR(500) NOT NULL,
    StartDate DATE NOT NULL,
    EndDate DATE NULL,
    Status NVARCHAR(50) NOT NULL, -- Chưa bắt đầu, Đang thực hiện, Hoàn thành, Quá hạn...
    Priority NVARCHAR(20) NULL, -- Cao, Trung bình, Thấp
    AssignedBy INT NULL, -- Người giao việc
    CreatedDate DATETIME DEFAULT GETDATE(),
    CreatedBy INT NULL,
    ModifiedDate DATETIME NULL,
    ModifiedBy INT NULL,
    
    FOREIGN KEY (EmployeeId) REFERENCES Employee(EmployeeId),
    FOREIGN KEY (AssignedBy) REFERENCES Employee(EmployeeId)
);
GO

-- Tạo bảng Lương
CREATE TABLE Salary (
    SalaryId INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeId INT NOT NULL,
    Month INT NOT NULL,
    Year INT NOT NULL,
    WorkingDays DECIMAL(5,1) NOT NULL, -- Số ngày công
    SalaryGradeId INT NOT NULL,
    BaseSalary DECIMAL(18,2) NOT NULL, -- Lương cơ bản
    Coefficient DECIMAL(10,2) NOT NULL, -- Hệ số lương
    PositionAllowance DECIMAL(18,2) DEFAULT 0, -- Phụ cấp chức vụ
    OtherAllowance DECIMAL(18,2) DEFAULT 0, -- Phụ cấp khác
    Bonus DECIMAL(18,2) DEFAULT 0, -- Thưởng
    Deduction DECIMAL(18,2) DEFAULT 0, -- Trừ
    SocialInsurance DECIMAL(18,2) DEFAULT 0, -- BHXH
    HealthInsurance DECIMAL(18,2) DEFAULT 0, -- BHYT
    UnemploymentInsurance DECIMAL(18,2) DEFAULT 0, -- BHTN
    IncomeTax DECIMAL(18,2) DEFAULT 0, -- Thuế TNCN
    NetSalary DECIMAL(18,2) NOT NULL, -- Lương thực lĩnh
    PaymentDate DATE NULL, -- Ngày trả lương
    Note NVARCHAR(500) NULL,
    Status NVARCHAR(50) NOT NULL, -- Chưa thanh toán, Đã thanh toán
    CreatedDate DATETIME DEFAULT GETDATE(),
    CreatedBy INT NULL,
    ModifiedDate DATETIME NULL,
    ModifiedBy INT NULL,
    
    FOREIGN KEY (EmployeeId) REFERENCES Employee(EmployeeId),
    FOREIGN KEY (SalaryGradeId) REFERENCES SalaryGrade(SalaryGradeId)
);
GO

-- Tạo bảng Nghỉ phép
CREATE TABLE Leave (
    LeaveId INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeId INT NOT NULL,
    LeaveType NVARCHAR(50) NOT NULL, -- Nghỉ phép năm, Nghỉ ốm, Nghỉ không lương...
    FromDate DATE NOT NULL,
    ToDate DATE NOT NULL,
    TotalDays DECIMAL(5,1) NOT NULL,
    Reason NVARCHAR(500) NOT NULL,
    Status NVARCHAR(50) NOT NULL, -- Chờ duyệt, Đã duyệt, Từ chối
    ApprovedBy INT NULL,
    ApprovedDate DATETIME NULL,
    CreatedDate DATETIME DEFAULT GETDATE(),
    CreatedBy INT NULL,
    
    FOREIGN KEY (EmployeeId) REFERENCES Employee(EmployeeId),
    FOREIGN KEY (ApprovedBy) REFERENCES Employee(EmployeeId)
);
GO

-- Tạo bảng User (để đăng nhập hệ thống)
CREATE TABLE [User] (
    UserId INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(255) NOT NULL,
    EmployeeId INT NULL,
    Role NVARCHAR(50) NOT NULL, -- Admin, Manager, Employee...
    LastLogin DATETIME NULL,
    IsActive BIT DEFAULT 1,
    CreatedDate DATETIME DEFAULT GETDATE(),
    
    FOREIGN KEY (EmployeeId) REFERENCES Employee(EmployeeId)
);
GO

-- Chèn dữ liệu mẫu vào các bảng
-- Thêm dữ liệu vào bảng phòng ban
INSERT INTO Department (DepartmentName, Description) VALUES 
(N'Ban Giám đốc', N'Ban lãnh đạo cơ quan'),
(N'Phòng Hành chính - Nhân sự', N'Quản lý nhân sự và hành chính'),
(N'Phòng Tài chính - Kế toán', N'Quản lý tài chính và kế toán'),
(N'Phòng Kỹ thuật', N'Phòng kỹ thuật và nghiên cứu'),
(N'Phòng Kinh doanh', N'Phòng kinh doanh và marketing');
GO

-- Thêm dữ liệu vào bảng chức vụ
INSERT INTO Position (PositionName, Description, Allowance) VALUES 
(N'Giám đốc', N'Giám đốc cơ quan', 5000000),
(N'Phó Giám đốc', N'Phó Giám đốc cơ quan', 3000000),
(N'Trưởng phòng', N'Quản lý phòng ban', 2000000),
(N'Phó phòng', N'Phó quản lý phòng ban', 1500000),
(N'Nhân viên', N'Nhân viên thông thường', 0);
GO

-- Thêm dữ liệu vào bảng trình độ
INSERT INTO Education (EducationName, Description) VALUES 
(N'Tiến sĩ', N'Trình độ tiến sĩ'),
(N'Thạc sĩ', N'Trình độ thạc sĩ'),
(N'Đại học', N'Trình độ đại học'),
(N'Cao đẳng', N'Trình độ cao đẳng'),
(N'Trung cấp', N'Trình độ trung cấp');
GO

-- Thêm dữ liệu vào bảng dân tộc
INSERT INTO Ethnicity (EthnicityName) VALUES 
(N'Kinh'),
(N'Tày'),
(N'Thái'),
(N'Mường'),
(N'Khmer');
GO

-- Thêm dữ liệu vào bảng tôn giáo
INSERT INTO Religion (ReligionName) VALUES 
(N'Không'),
(N'Phật giáo'),
(N'Công giáo'),
(N'Tin lành'),
(N'Cao đài');
GO

-- Thêm dữ liệu vào bảng loại nhân viên
INSERT INTO EmployeeType (TypeName, Description) VALUES 
(N'Biên chế', N'Nhân viên biên chế'),
(N'Hợp đồng', N'Nhân viên hợp đồng');
GO

-- Thêm dữ liệu vào bảng bậc lương
INSERT INTO SalaryGrade (GradeName, BasicSalary, Coefficient, Description) VALUES 
(N'Bậc 1', 1490000, 1.0, N'Bậc lương cơ bản'),
(N'Bậc 2', 1490000, 1.5, N'Bậc lương 2'),
(N'Bậc 3', 1490000, 2.0, N'Bậc lương 3'),
(N'Bậc 4', 1490000, 2.5, N'Bậc lương 4'),
(N'Bậc 5', 1490000, 3.0, N'Bậc lương 5');
GO 