/*
Автор: Колесник А.С.
e-mail: kolesnik.dev@yandex.ru

Задача №2 с элементами математики. 

Написать программу для операции "произведение массивов". 
Сама операция определяется так, как будто элементы массива - это коэффициенты полинома. 
Соответственно, произведение массивов - должно дать новый массив, коэффициенты которого соответсвуют нужному полиному.

Например, возьмем полином (x - 1) и полином (x + 2). Их можно представить в виде массивов [-1, 1] и [2, 1] соответственно. 
Индекс элемента в массиве соответствует степени x при этом коээфициенте, т.е. полином (x - 1) можно переписать как (-1 * x^0 + 1 * x^1), 
таким образом соответсвующий этому полиному массив будет иметь вид [-1, 1].

По указанному правилу произведение массивов [-1, 1] и [2, 1] должно быть равно [-2, 1, 1], т.к. (x - 1) * (x + 2) = (x^2 + x^1 - 2).
*/

#include <iostream>
#include <string>

#define u32 unsigned int
#define i32 int

using namespace std;

/*
Класс полином

Описание полинома:
1. Степень полинома(_u32Degree)
2. Коэффициенты полинома(_pOdds)

Методы:
getOdds()	- возвращает коэффициенты полинома
getDegree() - возвращает степень полинома
show()		- отображает полином в виде массива на экране

Конструктор:
В качестве параметров принимает степень и коэффициенты полинома, 
которыми инициализирует переменные _u32Degree, _pOdds 
*/
class Polinomial
{
public:
	Polinomial(u32 u32Degree, i32* pOdds) 
	{ 
		_u32Degree = u32Degree; 
		_pOdds = pOdds;
	}
	~Polinomial();
	

	i32* getOdds()	{ return _pOdds; }

	const u32  getDegree() { return _u32Degree; }

	void show();
private:
	u32 _u32Degree = 0;
	i32 *_pOdds = nullptr;
};

/*
Перегрузка оператора *(умножение) для объектов класса Polinomial
*/
Polinomial operator * (Polinomial factor_1, Polinomial factor_2)
{
	// Степень нового полинома
	u32 u32NewDegree = factor_1.getDegree() + factor_2.getDegree();

	// Массив для записи коэффициентов нового полинома
	i32 *pNewOdds = new i32[u32NewDegree + 1];
	
	for (size_t i = 0; i < u32NewDegree + 1; i++) pNewOdds[i] = 0;

	// Коэффициенты полинома 1
	i32 *pFactor1Odds = factor_1.getOdds();

	// Коэффициенты полинома 2
	i32 *pFactor2Odds = factor_2.getOdds();

	for (i32 i = factor_1.getDegree(); i >= 0; i--)
	{
		for (i32 j = factor_2.getDegree(); j >= 0; j--)
		{
			pNewOdds[i + j] += pFactor1Odds[i] * pFactor2Odds[j];
		}
	}
	
	return Polinomial(u32NewDegree, pNewOdds);
}

bool operator == (Polinomial factor_1, Polinomial factor_2)
{
	// Проверка степени полиномов
	if (factor_1.getDegree() != factor_2.getDegree()) return false;

	// Коэффициенты полинома 1
	i32 *factor1Odds = factor_1.getOdds();
	
	// Коэффициенты полинома 2
	i32 *factor2Odds = factor_2.getOdds();

	for (i32 i = 0; i < factor_1.getDegree() + 1; i++)
	{
		if (factor1Odds[i] != factor2Odds[i]) return false;
	}

	return true;
}

/*
Отображение полинома на экране в формате массива
*/
void Polinomial::show()
{
	if (_u32Degree == 0) { cout << "Polynomial does not exist" << endl; return; }
	
	cout << "[ ";

	for (int i = 0; i < _u32Degree + 1; i++) cout << _pOdds[i] << " ";

	cout << "]" << endl;
}

Polinomial::~Polinomial()
{
}

void testMultiplyPolinomials(string message, Polinomial factor_1, Polinomial factor_2, Polinomial resultTest)
{
	cout << message << ": ";
	Polinomial multiplyPolinimial = factor_1 * factor_2;
	if (multiplyPolinimial == resultTest) cout << "Test passed successfully" << endl;
	else cout << "Test failed" << endl;
}

int main()
{
	// Параметры полинома 1
	u32 u32DegreeP1 = 1;
	i32 pOddsP1[2] = { -1,1 };

	// Параметры полинома 2
	u32 u32DegreeP2 = 1;
	i32 pOddsP2[2] = { 2,1 };

	Polinomial polinomial_1(u32DegreeP1, pOddsP1);
	Polinomial polinomial_2(u32DegreeP2, pOddsP2);

	// Умножение полиномов
	Polinomial multi_polinomial = polinomial_1 * polinomial_2;
	//multi_polinomial.show();

	// Тест 1 ------------------------------------

	// Параметры полинома 1
	u32 u32DegreeP1_test1 = 2;
	i32 pOddsP1_test1[3] = { 0,-1, 1 };

	// Параметры полинома 2
	u32 u32DegreeP2_test1 = 1;
	i32 pOddsP2_test1[2] = { 1,1 };

	// Параметры результирующего полинома
	u32 u32DegreeP3_test1 = 3;
	i32 pOddsP3_test1[4] = { 0, -1, 0, 1 };

	testMultiplyPolinomials(
		"Test 1",
		Polinomial(u32DegreeP1_test1, pOddsP1_test1),
		Polinomial(u32DegreeP2_test1, pOddsP2_test1),
		Polinomial(u32DegreeP3_test1, pOddsP3_test1)
	);
	
	// Тест 2 ------------------------------------

	// Параметры полинома 1
	u32 u32DegreeP1_test2 = 1;
	i32 pOddsP1_test2[2] = { -1, 2 };

	// Параметры полинома 2
	u32 u32DegreeP2_test2 = 1;
	i32 pOddsP2_test2[2] = { -2, 3 };

	// Параметры результирующего полинома
	u32 u32DegreeP3_test2 = 2;
	i32 pOddsP3_test2[3] = { 2, -7, 6 };

	testMultiplyPolinomials(
		"Test 2",
		Polinomial(u32DegreeP1_test2, pOddsP1_test2),
		Polinomial(u32DegreeP2_test2, pOddsP2_test2),
		Polinomial(u32DegreeP3_test2, pOddsP3_test2)
	);
	return 0;
}