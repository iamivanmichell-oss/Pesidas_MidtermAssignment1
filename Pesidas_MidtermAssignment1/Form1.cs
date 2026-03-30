using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pesidas_MidtermAssignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPA1Score_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox49_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPLabPracTotal_TextChanged(object sender, EventArgs e)
        {

        }
		private double CalculateGPA(double finalGrade)
		{
			double gpa;
			if (finalGrade >= 97.5)
				gpa = 1.0;
			else if (finalGrade >= 94.5)
				gpa = 1.25;
			else if (finalGrade >= 91.5)
				gpa = 1.5;
			else if (finalGrade >= 88.5)
				gpa = 1.75;
			else if (finalGrade >= 85.0)
				gpa = 2.0;
			else if (finalGrade >= 82.5)
				gpa = 2.25;
			else if (finalGrade >= 80.0)
				gpa = 2.5;
			else if (finalGrade >= 77.5)
				gpa = 2.75;
			else if (finalGrade >= 75.0)
				gpa = 3.0;
			else
				gpa = 5.0; // Failed
			return gpa;
		}
		private void btnCompute_Click(object sender, EventArgs e)
		{
			double pA1Score, pA1Item;
			double pA2Score, pA2Item;
			double pSW1Score, pSW1Item;
			double pSW2Score, pSW2Item;
			double pRec1Score, pRec1Item;
			double pRec2Score, pRec2Item;

			double pLabAct1Score, pLabAct1Item;
			double pLabAct2Score, pLabAct2Item;
			double pLabAct3Score, pLabAct3Item;
			double pLabAct4Score, pLabAct4Item;

			double pQuiz1Score, pQuiz1Item;
			double pQuiz2Score, pQuiz2Item;
			double pQuiz3Score, pQuiz3Item;

			double pLabPrac1Score, pLabPrac1Item;
			double pLabPrac2Score, pLabPrac2Item;

			double pExamScore, pExamItem;

			
			double mA1Score, mA1Item;
			double mA2Score, mA2Item;
			double mSW1Score, mSW1Item;
			double mSW2Score, mSW2Item;
			double mRec1Score, mRec1Item;
			double mRec2Score, mRec2Item;

			double mLabAct1Score, mLabAct1Item;
			double mLabAct2Score, mLabAct2Item;
			double mLabAct3Score, mLabAct3Item;
			double mLabAct4Score, mLabAct4Item;

			double mQuiz1Score, mQuiz1Item;
			double mQuiz2Score, mQuiz2Item;
			double mQuiz3Score, mQuiz3Item;

			double mLabPrac1Score, mLabPrac1Item;
			double mLabPrac2Score, mLabPrac2Item;

			double mExamScore, mExamItem;

			double fA1Score, fA1Item;
			double fA2Score, fA2Item;
			double fSW1Score, fSW1Item;
			double fSW2Score, fSW2Item;
			double fRec1Score, fRec1Item;
			double fRec2Score, fRec2Item;

			double fLabAct1Score, fLabAct1Item;
			double fLabAct2Score, fLabAct2Item;
			double fLabAct3Score, fLabAct3Item;
			double fLabAct4Score, fLabAct4Item;

			double fQuiz1Score, fQuiz1Item;
			double fQuiz2Score, fQuiz2Item;
			double fQuiz3Score, fQuiz3Item;

			double manuscriptScore, manuscriptItem;
			double presentationScore, presentationItem;

			double fExamScore, fExamItem;

			
			try
			{
				// PRELIM - Class Participation
				pA1Score = double.Parse(txtPA1Score.Text);
				pA1Item = double.Parse(txtPA1Item.Text);
				pA2Score = double.Parse(txtPA2Score.Text);
				pA2Item = double.Parse(txtPA2Item.Text);
				pSW1Score = double.Parse(txtPSW1Score.Text);
				pSW1Item = double.Parse(txtPSW1Item.Text);
				pSW2Score = double.Parse(txtPSW2Score.Text);
				pSW2Item = double.Parse(txtPSW2Item.Text);
				pRec1Score = double.Parse(txtPRec1Score.Text);
				pRec1Item = double.Parse(txtPRec1Item.Text);
				pRec2Score = double.Parse(txtPRec2Score.Text);
				pRec2Item = double.Parse(txtPRec2Item.Text);

				// PRELIM - Lab Exercise
				pLabAct1Score = double.Parse(txtPLabAct1Score.Text);
				pLabAct1Item = double.Parse(txtPLabAct1Item.Text);
				pLabAct2Score = double.Parse(txtPLabAct2Score.Text);
				pLabAct2Item = double.Parse(txtPLabAct2Item.Text);
				pLabAct3Score = double.Parse(txtPLabAct3Score.Text);
				pLabAct3Item = double.Parse(txtPLabAct3Item.Text);
				pLabAct4Score = double.Parse(txtPLabAct4Score.Text);
				pLabAct4Item = double.Parse(txtPLabAct4Item.Text);

				// PRELIM - Quizzes
				pQuiz1Score = double.Parse(txtPQuiz1Score.Text);
				pQuiz1Item = double.Parse(txtPQuiz1Item.Text);
				pQuiz2Score = double.Parse(txtPQuiz2Score.Text);
				pQuiz2Item = double.Parse(txtPQuiz2Item.Text);
				pQuiz3Score = double.Parse(txtPQuiz3Score.Text);
				pQuiz3Item = double.Parse(txtPQuiz3Item.Text);

				// PRELIM - Lab Exam
				pLabPrac1Score = double.Parse(txtPLabPrac1Score.Text);
				pLabPrac1Item = double.Parse(txtPLabPrac1Item.Text);
				pLabPrac2Score = double.Parse(txtPLabPrac2Score.Text);
				pLabPrac2Item = double.Parse(txtPLabPrac2Item.Text);

				// PRELIM - Written Exam
				pExamScore = double.Parse(txtPExamScore.Text);
				pExamItem = double.Parse(txtPExamItem.Text);

				// MIDTERM - Class Participation
				mA1Score = double.Parse(txtMA1Score.Text);
				mA1Item = double.Parse(txtMA1Item.Text);
				mA2Score = double.Parse(txtMA2Score.Text);
				mA2Item = double.Parse(txtMA2Item.Text);
				mSW1Score = double.Parse(txtMSW1Score.Text);
				mSW1Item = double.Parse(txtMSW1Item.Text);
				mSW2Score = double.Parse(txtMSW2Score.Text);
				mSW2Item = double.Parse(txtMSW2Item.Text);
				mRec1Score = double.Parse(txtMRec1Score.Text);
				mRec1Item = double.Parse(txtMRec1Item.Text);
				mRec2Score = double.Parse(txtRec2Score.Text);
				mRec2Item = double.Parse(txtMRec2Item.Text);

				// MIDTERM - Lab Exercise
				mLabAct1Score = double.Parse(txtMLabAct1Score.Text);
				mLabAct1Item = double.Parse(txtMLabAct1Item.Text);
				mLabAct2Score = double.Parse(txtMLabAct2Score.Text);
				mLabAct2Item = double.Parse(txtMLabAct2Item.Text);
				mLabAct3Score = double.Parse(txtMLabAct3Score.Text);
				mLabAct3Item = double.Parse(txtMLabAct3Item.Text);
				mLabAct4Score = double.Parse(txtMLabAct4Score.Text);
				mLabAct4Item = double.Parse(txtMLabAct4Item.Text);

				// MIDTERM - Quizzes
				mQuiz1Score = double.Parse(txtMQuiz1Score.Text);
				mQuiz1Item = double.Parse(txtMQuiz1Item.Text);
				mQuiz2Score = double.Parse(txtMQuiz2Score.Text);
				mQuiz2Item = double.Parse(txtMQuiz2Item.Text);
				mQuiz3Score = double.Parse(txtMQuiz3Score.Text);
				mQuiz3Item = double.Parse(txtMQuiz3Item.Text);

				// MIDTERM - Lab Exam
				mLabPrac1Score = double.Parse(txtMLabPrac1Score.Text);
				mLabPrac1Item = double.Parse(txtMLabPrac1Item.Text);
				mLabPrac2Score = double.Parse(txtMLabPrac2Score.Text);
				mLabPrac2Item = double.Parse(txtMLabPrac2Item.Text);

				// MIDTERM - Written Exam
				mExamScore = double.Parse(txtMExamScore.Text);
				mExamItem = double.Parse(txtMExamItem.Text);

				// FINALS - Class Participation
				fA1Score = double.Parse(txtFA1Score.Text);
				fA1Item = double.Parse(txtFA1Item.Text);
				fA2Score = double.Parse(txtFA2Score.Text);
				fA2Item = double.Parse(txtFA2Item.Text);
				fSW1Score = double.Parse(txtFSW1Score.Text);
				fSW1Item = double.Parse(txtFSW1Item.Text);
				fSW2Score = double.Parse(txtFSW2Score.Text);
				fSW2Item = double.Parse(txtFSW2Item.Text);
				fRec1Score = double.Parse(txtFRec1Score.Text);
				fRec1Item = double.Parse(txtFRec1Item.Text);
				fRec2Score = double.Parse(txtFRec2Score.Text);
				fRec2Item = double.Parse(txtFRec2Item.Text);

				// FINALS - Lab Exercise
				fLabAct1Score = double.Parse(txtFLabAct1Score.Text);
				fLabAct1Item = double.Parse(txtFLabAct1Item.Text);
				fLabAct2Score = double.Parse(txtFLabAct2Score.Text);
				fLabAct2Item = double.Parse(txtFLabAct2Item.Text);
				fLabAct3Score = double.Parse(txtFLabAct3Score.Text);
				fLabAct3Item = double.Parse(txtFLabAct3Item.Text);
				fLabAct4Score = double.Parse(txtFLabAct4Score.Text);
				fLabAct4Item = double.Parse(txtFLabAct4Item.Text);

				// FINALS - Quizzes
				fQuiz1Score = double.Parse(txtFQuiz1Score.Text);
				fQuiz1Item = double.Parse(txtFQuiz1Item.Text);
				fQuiz2Score = double.Parse(txtFQuiz2Score.Text);
				fQuiz2Item = double.Parse(txtFQuiz2Item.Text);
				fQuiz3Score = double.Parse(txtFQuiz3Score.Text);
				fQuiz3Item = double.Parse(txtFQuiz3Item.Text);

				// FINALS - Final Project
				manuscriptScore = double.Parse(txtManuscriptScore.Text);
				manuscriptItem = double.Parse(txtManuscriptItem.Text);
				presentationScore = double.Parse(txtPresentationScore.Text);
				presentationItem = double.Parse(txtPresentationItem.Text);

				// FINALS - Written Exam
				fExamScore = double.Parse(txtFExamScore.Text);
				fExamItem = double.Parse(txtFExamItem.Text);
			}
			catch (FormatException)
			{
				MessageBox.Show("Please enter valid numbers in all fields.");
				return;
			}

			double[] scores = {
				pA1Score, pA2Score, pSW1Score, pSW2Score, pRec1Score, pRec2Score,
				pLabAct1Score, pLabAct2Score, pLabAct3Score, pLabAct4Score,
				pQuiz1Score, pQuiz2Score, pQuiz3Score,
				pLabPrac1Score, pLabPrac2Score,
				pExamScore,
				mA1Score, mA2Score, mSW1Score, mSW2Score, mRec1Score, mRec2Score,
				mLabAct1Score, mLabAct2Score, mLabAct3Score, mLabAct4Score,
				mQuiz1Score, mQuiz2Score, mQuiz3Score,
				mLabPrac1Score, mLabPrac2Score,
				mExamScore,
				fA1Score, fA2Score, fSW1Score, fSW2Score, fRec1Score, fRec2Score,
				fLabAct1Score, fLabAct2Score, fLabAct3Score, fLabAct4Score,
				fQuiz1Score, fQuiz2Score, fQuiz3Score,
				manuscriptScore, presentationScore,
				fExamScore
			};

			double[] totals = {
				pA1Item, pA2Item, pSW1Item, pSW2Item, pRec1Item, pRec2Item,
				pLabAct1Item, pLabAct2Item, pLabAct3Item, pLabAct4Item,
				pQuiz1Item, pQuiz2Item, pQuiz3Item,
				pLabPrac1Item, pLabPrac2Item,
				pExamItem,
				mA1Item, mA2Item, mSW1Item, mSW2Item, mRec1Item, mRec2Item,
				mLabAct1Item, mLabAct2Item, mLabAct3Item, mLabAct4Item,
				mQuiz1Item, mQuiz2Item, mQuiz3Item,
				mLabPrac1Item, mLabPrac2Item,
				mExamItem,
				fA1Item, fA2Item, fSW1Item, fSW2Item, fRec1Item, fRec2Item,
				fLabAct1Item, fLabAct2Item, fLabAct3Item, fLabAct4Item,
				fQuiz1Item, fQuiz2Item, fQuiz3Item,
				manuscriptItem, presentationItem,
				fExamItem
			};


			for (int i = 0; i < scores.Length; i++)
			{
				if (scores[i] < 0 || totals[i] < 0)
				{
					MessageBox.Show("Values must not be negative.");
					return;
				}
				else if (scores[i] > totals[i])
				{
					MessageBox.Show("Score cannot be greater than Total.");
					return;
				}
			}

			
			for (int i = 0; i < totals.Length; i++)
			{
				if (totals[i] == 0)
				{
					MessageBox.Show("Total score cannot be zero.");
					return;
				}
			}

			

			// PRELIM - Class Participation 
			double pA1Percent = (pA1Score / pA1Item) * 60 + 40;
			double pA2Percent = (pA2Score / pA2Item) * 60 + 40;
			double pSW1Percent = (pSW1Score / pSW1Item) * 60 + 40;
			double pSW2Percent = (pSW2Score / pSW2Item) * 60 + 40;
			double pRec1Percent = (pRec1Score / pRec1Item) * 60 + 40;
			double pRec2Percent = (pRec2Score / pRec2Item) * 60 + 40;

			
			txtPA1Percent.Text = pA1Percent.ToString("F2");
			txtPA2Percent.Text = pA2Percent.ToString("F2");
			txtPSW1Percent.Text = pSW1Percent.ToString("F2");
			txtPSW2Percent.Text = pSW2Percent.ToString("F2");
			txtPRec1Percent.Text = pRec1Percent.ToString("F2");
			txtPRec2Percent.Text = pRec2Percent.ToString("F2");

			
			double pClassPerformance = (pA1Percent + pA2Percent + pSW1Percent + pSW2Percent + pRec1Percent + pRec2Percent) / 6;
			double pClassPerformanceEquivalent = (pClassPerformance / 100) * 10; 
			txtPClassPartTotal.Text = pClassPerformanceEquivalent.ToString("F2");

			// PRELIM - Lab Exercise 
			double pLabAct1Percent = (pLabAct1Score / pLabAct1Item) * 60 + 40;
			double pLabAct2Percent = (pLabAct2Score / pLabAct2Item) * 60 + 40;
			double pLabAct3Percent = (pLabAct3Score / pLabAct3Item) * 60 + 40;
			double pLabAct4Percent = (pLabAct4Score / pLabAct4Item) * 60 + 40;

			txtPLabAct1Percent.Text = pLabAct1Percent.ToString("F2");
			txtPLabAct2Percent.Text = pLabAct2Percent.ToString("F2");
			txtPLabAct3Percent.Text = pLabAct3Percent.ToString("F2");
			txtPLabAct4Percent.Text = pLabAct4Percent.ToString("F2");

			double pLabExercise = (pLabAct1Percent + pLabAct2Percent + pLabAct3Percent + pLabAct4Percent) / 4;
			double pLabExerciseEquivalent = (pLabExercise / 100) * 10;
			txtPLabExTotal.Text = pLabExerciseEquivalent.ToString("F2");

			// PRELIM - Quizzes 
			double pQuiz1Percent = (pQuiz1Score / pQuiz1Item) * 60 + 40;
			double pQuiz2Percent = (pQuiz2Score / pQuiz2Item) * 60 + 40;
			double pQuiz3Percent = (pQuiz3Score / pQuiz3Item) * 60 + 40;

			txtPQuiz1Percent.Text = pQuiz1Percent.ToString("F2");
			txtPQuiz2Percent.Text = pQuiz2Percent.ToString("F2");
			txtPQuiz3Percent.Text = pQuiz3Percent.ToString("F2");

			double pQuizzes = (pQuiz1Percent + pQuiz2Percent + pQuiz3Percent) / 3;
			double pQuizzesEquivalent = (pQuizzes / 100) * 20;	
			txtPQuizTotal.Text = pQuizzesEquivalent.ToString("F2");

			// PRELIM - Lab Exam 
			double pLabPrac1Percent = (pLabPrac1Score / pLabPrac1Item) * 60 + 40;
			double pLabPrac2Percent = (pLabPrac2Score / pLabPrac2Item) * 60 + 40;

			txtPLabPrac1Percent.Text = pLabPrac1Percent.ToString("F2");
			txtPLabPrac2Percent.Text = pLabPrac2Percent.ToString("F2");

			double pLabExam = (pLabPrac1Percent + pLabPrac2Percent) / 2;
			double pLabExamEquivalent = (pLabExam / 100) * 20;
			txtPLabPracTotal.Text = pLabExamEquivalent.ToString("F2");

			// PRELIM - Written Exam 
			double pExamPercent = (pExamScore / pExamItem) * 60 + 40;
			txtPExamPercent.Text = pExamPercent.ToString("F2");
			double pExamEquivalent = (pExamPercent / 100) * 40;
			txtPExamTotal.Text = pExamEquivalent.ToString("F2");

			// PRELIM TOTAL 
			double prelimGrade = (pClassPerformance * 0.10) +
								 (pLabExercise * 0.10) +
								 (pQuizzes * 0.20) +
								 (pLabExam * 0.20) +
								 (pExamPercent * 0.40);
			
			lblPrelimGrade.Text = prelimGrade.ToString("F2");
			lblpGPA.Text = CalculateGPA(prelimGrade).ToString("F2");
			if (prelimGrade < 75)
			{
				lblPrelimGrade.ForeColor = Color.Red;
				lblpGPA.ForeColor = Color.Red;
			}

			
			//  MIDTERM - Class Participation 
			double mA1Percent = (mA1Score / mA1Item) * 60 + 40;
			double mA2Percent = (mA2Score / mA2Item) * 60 + 40;
			double mSW1Percent = (mSW1Score / mSW1Item) * 60 + 40;
			double mSW2Percent = (mSW2Score / mSW2Item) * 60 + 40;
			double mRec1Percent = (mRec1Score / mRec1Item) * 60 + 40;
			double mRec2Percent = (mRec2Score / mRec2Item) * 60 + 40;

			txtMA1Percent.Text = mA1Percent.ToString("F2");
			txtMA2Percent.Text = mA2Percent.ToString("F2");
			txtMSW1Percent.Text = mSW1Percent.ToString("F2");
			txtMSW2Percent.Text = mSW2Percent.ToString("F2");
			txtMRec1Percent.Text = mRec1Percent.ToString("F2");
			txtMRec2Percent.Text = mRec2Percent.ToString("F2");

			double mClassPerformance = (mA1Percent + mA2Percent + mSW1Percent + mSW2Percent + mRec1Percent + mRec2Percent) / 6;
			double mClassPerformanceEquivalent = (mClassPerformance / 100) * 10;
			txtMClassPartTotal.Text = mClassPerformanceEquivalent.ToString("F2");

			//  MIDTERM - Lab Exercise 
			double mLabAct1Percent = (mLabAct1Score / mLabAct1Item) * 60 + 40;
			double mLabAct2Percent = (mLabAct2Score / mLabAct2Item) * 60 + 40;
			double mLabAct3Percent = (mLabAct3Score / mLabAct3Item) * 60 + 40;
			double mLabAct4Percent = (mLabAct4Score / mLabAct4Item) * 60 + 40;

			txtMLabAct1Percent.Text = mLabAct1Percent.ToString("F2");
			txtMLabAct2Percent.Text = mLabAct2Percent.ToString("F2");
			txtMLabAct3Percent.Text = mLabAct3Percent.ToString("F2");
			txtMLabAct4Percent.Text = mLabAct4Percent.ToString("F2");

			double mLabExercise = (mLabAct1Percent + mLabAct2Percent + mLabAct3Percent + mLabAct4Percent) / 4;
			double mLabExerciseEquivalent = (mLabExercise / 100) * 10;
			txtMLabExTotal.Text = mLabExerciseEquivalent.ToString("F2");

			//  MIDTERM - Quizzes 
			double mQuiz1Percent = (mQuiz1Score / mQuiz1Item) * 60 + 40;
			double mQuiz2Percent = (mQuiz2Score / mQuiz2Item) * 60 + 40;
			double mQuiz3Percent = (mQuiz3Score / mQuiz3Item) * 60 + 40;

			txtMQuiz1Percent.Text = mQuiz1Percent.ToString("F2");
			txtMQuiz2Percent.Text = mQuiz2Percent.ToString("F2");
			txtMQuiz3Percent.Text = mQuiz3Percent.ToString("F2");

			double mQuizzes = (mQuiz1Percent + mQuiz2Percent + mQuiz3Percent) / 3;
			double mQuizzesEquivalent = (mQuizzes / 100) * 20;
			txtMQuizTotal.Text = mQuizzesEquivalent.ToString("F2");

			//  MIDTERM - Lab Exam 
			double mLabPrac1Percent = (mLabPrac1Score / mLabPrac1Item) * 60 + 40;
			double mLabPrac2Percent = (mLabPrac2Score / mLabPrac2Item) * 60 + 40;

			txtMLabPrac1Percent.Text = mLabPrac1Percent.ToString("F2");
			txtMLabPrac2Percent.Text = mLabPrac2Percent.ToString("F2");

			double mLabExam = (mLabPrac1Percent + mLabPrac2Percent) / 2;
			double mLabExamEquivalent = (mLabExam / 100) * 20;
			txtMLabPracTotal.Text = mLabExamEquivalent.ToString("F2");

			// MIDTERM - Written Exam
			double mExamPercent = (mExamScore / mExamItem) * 60 + 40;
			txtMExamPercent.Text = mExamPercent.ToString("F2");
			double mExamEquivalent = (mExamPercent / 100) * 40;
			txtMExamTotal.Text = mExamEquivalent.ToString("F2");

			// MIDTERM TOTAL 
			double midtermGrade = (mClassPerformance * 0.10) +
								  (mLabExercise * 0.10) +
								  (mQuizzes * 0.20) +
								  (mLabExam * 0.20) +
								  (mExamPercent * 0.40);

			lblMidtermGrade.Text = midtermGrade.ToString("F2");
			lblmGPA.Text = CalculateGPA(midtermGrade).ToString("F2");
			if (midtermGrade < 75)
			{
				lblMidtermGrade.ForeColor = Color.Red;
				lblmGPA.ForeColor = Color.Red;
			}

			
			// FINALS - Class Participation 
			double fA1Percent = (fA1Score / fA1Item) * 60 + 40;
			double fA2Percent = (fA2Score / fA2Item) * 60 + 40;
			double fSW1Percent = (fSW1Score / fSW1Item) * 60 + 40;
			double fSW2Percent = (fSW2Score / fSW2Item) * 60 + 40;
			double fRec1Percent = (fRec1Score / fRec1Item) * 60 + 40;
			double fRec2Percent = (fRec2Score / fRec2Item) * 60 + 40;

			txtFA1Percent.Text = fA1Percent.ToString("F2");
			txtFA2Percent.Text = fA2Percent.ToString("F2");
			txtFSW1Percent.Text = fSW1Percent.ToString("F2");
			txtFSW2Percent.Text = fSW2Percent.ToString("F2");
			txtFRec1Percent.Text = fRec1Percent.ToString("F2");
			txtFRec2Percent.Text = fRec2Percent.ToString("F2");

			double fClassPerformance = (fA1Percent + fA2Percent + fSW1Percent + fSW2Percent + fRec1Percent + fRec2Percent) / 6;
			double fClassPerformanceEquivalent = (fClassPerformance / 100) * 5;
			txtFClassPartTotal.Text = fClassPerformanceEquivalent.ToString("F2");

			// FINALS - Lab Exercise
			double fLabAct1Percent = (fLabAct1Score / fLabAct1Item) * 60 + 40;
			double fLabAct2Percent = (fLabAct2Score / fLabAct2Item) * 60 + 40;
			double fLabAct3Percent = (fLabAct3Score / fLabAct3Item) * 60 + 40;
			double fLabAct4Percent = (fLabAct4Score / fLabAct4Item) * 60 + 40;

			txtFLabAct1Percent.Text = fLabAct1Percent.ToString("F2");
			txtFLabAct2Percent.Text = fLabAct2Percent.ToString("F2");
			txtFLabAct3Percent.Text = fLabAct3Percent.ToString("F2");
			txtFLabAct4Percent.Text = fLabAct4Percent.ToString("F2");

			double fLabExercise = (fLabAct1Percent + fLabAct2Percent + fLabAct3Percent + fLabAct4Percent) / 4;
			double fLabExerciseEquivalent = (fLabExercise / 100) * 10;
			txtFLabExTotal.Text = fLabExerciseEquivalent.ToString("F2");

			// FINALS - Quizzes 
			double fQuiz1Percent = (fQuiz1Score / fQuiz1Item) * 60 + 40;
			double fQuiz2Percent = (fQuiz2Score / fQuiz2Item) * 60 + 40;
			double fQuiz3Percent = (fQuiz3Score / fQuiz3Item) * 60 + 40;

			txtFQuiz1Percent.Text = fQuiz1Percent.ToString("F2");
			txtFQuiz2Percent.Text = fQuiz2Percent.ToString("F2");
			txtFQuiz3Percent.Text = fQuiz3Percent.ToString("F2");

			double fQuizzes = (fQuiz1Percent + fQuiz2Percent + fQuiz3Percent) / 3;
			double fQuizzesEquivalent = (fQuizzes / 100) * 20;
			txtFQuizTotal.Text = fQuizzesEquivalent.ToString("F2");

			// FINALS Final Project 
			double manuscriptPercent = (manuscriptScore / manuscriptItem) * 60 + 40;
			double presentationPercent = (presentationScore / presentationItem) * 60 + 40;

			txtManuscriptPercent.Text = manuscriptPercent.ToString("F2");
			txtPresentationPercent.Text = presentationPercent.ToString("F2");

			double fFinalProject = (manuscriptPercent + presentationPercent) / 2;
			double fFinalProjectEquivalent = (fFinalProject / 100) * 25;
			txtProjectTotal.Text = fFinalProjectEquivalent.ToString("F2");

			// FINALS - Written Exam 
			double fExamPercent = (fExamScore / fExamItem) * 60 + 40;
			txtFExamPercent.Text = fExamPercent.ToString("F2");
			double fExamEquivalent = (fExamPercent / 100) * 40;
			txtFExamTotal.Text = fExamEquivalent.ToString("F2");

			// FINALS TOTAL
			double finalsGrade = (fClassPerformance * 0.05) +
								 (fLabExercise * 0.10) +
								 (fQuizzes * 0.20) +
								 (fFinalProject * 0.25) +
								 (fExamPercent * 0.40);

			lblFinalsGrade.Text = finalsGrade.ToString("F2");
			lblfGPA.Text = CalculateGPA(finalsGrade).ToString("F2");
			if (finalsGrade < 75)
			{
				lblFinalsGrade.ForeColor = Color.Red;
				lblfGPA.ForeColor = Color.Red;
			}

			
			// FINAL GRADE (GWA) 
			double finalGrade = (prelimGrade * 0.33) +
								(midtermGrade * 0.33) +
								(finalsGrade * 0.33);

			lblGWA.Text = finalGrade.ToString("F2");
			lblGPA.Text = CalculateGPA(finalGrade).ToString("F2");

			//STATUS
			if (finalGrade >= 75)
			{
				lblStatus.Text = "PASSED";
				lblStatus.ForeColor = Color.Green;
			}
			else
			{
				lblStatus.Text = "FAILED";
				lblGPA.ForeColor = Color.Red;
				lblStatus.ForeColor = Color.Red;
			}
		}
		

		private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

		private void btnClear_Click(object sender, EventArgs e)
		{
			
			foreach (Control ctrl in this.Controls)
			{
				ClearControls(ctrl);
			}

			lblGWA.Text = "____";
			lblStatus.Text = "____";
			lblStatus.ForeColor = Color.Black;
			lblMidtermGrade.Text = "____";
			lblMidtermGrade.ForeColor = Color.Black;
			lblFinalsGrade.Text = "____";
			lblFinalsGrade.ForeColor = Color.Black;
			lblPrelimGrade.Text = "____";
			lblPrelimGrade.ForeColor = Color.Black;
			lblGPA.Text = "____";
			lblGPA.ForeColor = Color.Black;
			lblpGPA.Text = "____";
			lblpGPA.ForeColor = Color.Black;
			lblmGPA.Text = "____";
			lblmGPA.ForeColor = Color.Black;
			lblfGPA.Text = "____";
			lblfGPA.ForeColor = Color.Black;
		}

		
		private void ClearControls(Control parent)
		{
			foreach (Control ctrl in parent.Controls)
			{
				if (ctrl is TextBox)
					((TextBox)ctrl).Clear();
				else if (ctrl.HasChildren)
					ClearControls(ctrl);
			}
		}
	}
}
