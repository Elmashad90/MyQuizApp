MyQuizApp - النسخة المعدلة

طريقة التشغيل:
1) افتح MyQuizApp.sln في Visual Studio.
2) اضغط Start / F5.
3) يمكن الدخول بالمستخدم الافتراضي:
   Username: Ahmed
   Password: 12123
4) أو اضغط Create New Account من شاشة Login وسجل مستخدم جديد.

أهم التعديلات:
- تعديل Login ليقرأ المستخدمين من users.txt بدل اسم وباسورد ثابتين داخل الكود.
- إضافة رابط Create New Account في شاشة Login وفتح شاشة Sign Up منه.
- إكمال شاشة Sign Up: تحقق من البيانات، تأكيد الباسورد، منع تكرار اسم المستخدم، وحفظ المستخدم في users.txt.
- إخفاء Password و Confirm Password أثناء الكتابة.
- تشغيل كل أزرار المواد: OOP / Mathematics II / Electric & Electronic Circuits / Statistics.
- جعل Form1 يستقبل اسم ملف الأسئلة واسم المادة بدل الاعتماد على ملف واحد فقط.
- إضافة ملفات أسئلة لكل مادة:
  MyProject.txt
  Mathematics.txt
  Electric.txt
  Statistics.txt
- إضافة ملفات الأسئلة داخل المشروع كـ Content ويتم نسخها تلقائيًا إلى bin عند التشغيل.
- تحسين قراءة الأسئلة: لو الملف ناقص أو فيه سطر غلط البرنامج لا يقع بالكامل.
- إصلاح زر Finish بحيث يوقف التايمر ويحسب إجابة السؤال الحالي قبل عرض النتيجة.
- إصلاح Retry في شاشة Result ليعيد نفس المادة التي كان الطالب يمتحن فيها.
- إيقاف توقيع الـ manifests في المشروع لتقليل مشاكل البناء على أجهزة مختلفة.

صيغة ملف الأسئلة:
Question Text|Choice1,Choice2,Choice3,Choice4|CorrectAnswerIndex|Level

مهم:
CorrectAnswerIndex يبدأ من صفر:
0 = الاختيار الأول
1 = الاختيار الثاني
2 = الاختيار الثالث
3 = الاختيار الرابع

Level يكون واحد من:
Easy
Medium
Hard
