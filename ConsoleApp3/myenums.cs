namespace ConsoleApp3
{
    enum myenums
    {        
        eBP_Jisu = 0,
		eBP_Jennie,
		eBP_Roje,
		eBP_Lisa,
    }
    enum eMovement
    {
        eMoveLeft = 97,
        eMoveRight = 100,
        eMoveTop = 119,
        eMoveDown = 115,
    }
    enum eArraySize
    {
        eAS_2 =2,
        eAS_4 =4,
        eAS_8 =8,
        eAS_16=16,
    }

    enum eSubjects
    {
        eSub_kor = 0, //국어
        eSub_Math,    //수학
        eSub_Cnt,     //갯수
        eSub_Max,
    }
    enum eMacro
    {
        Ea = 2,
        Eb = 4,
        Ec = 8,
        Ed = 16,

    }
    enum eFood
    {
        kimchiJJigae = 1,
        bulgogi = 2,
        ksoup = 3,

        stake = 6,
        Tbonestake = 7,
        porkcutlet = 8,
    }
    enum eError
    {
        eError_BufferSize_NotEqual = 1,
        eError_Not_Equal,
        eError_NULL,

        eOK=0,
    }
    enum eGender
    {
        eGender_Man = 0,
        eGender_Women = 1,
        eGender_Neuter = 2,
    }

    enum eTeacherType
    {
        eTeacher_kor =0,
        eTeacher_Music,
        eTeacher_Math,
        eTeacher_Max,
    }
}