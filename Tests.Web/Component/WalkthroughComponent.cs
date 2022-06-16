using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tests.Database.Model;
using Tests.Logis.ModelView;
using Tests.Logis.Service;

namespace Tests.Web.Component
{
    public class WalkthroughComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager NavigationManager { get; set; }

        [Inject]
        protected QuestionsServises _questionsServises { get; set; }

        [Inject]
        protected AnswerOptionsServises _answerOptionsServises { get; set; }

        [Inject]
        protected ISessionStorageService session { get; set; }

        [Parameter]
        public dynamic Id { get; set; }

        protected int NumperElement = 0;
        protected int value = 1;
        protected bool next = true;

        public bool? IsDisabled { get; set; }
        public bool? IsVisible { get; set; }

        protected Questions questions;
        protected List<Questions> questionsCollections;
        protected List<AnswerOptions> answer = new List<AnswerOptions>();

        protected override async Task OnInitializedAsync()
        {
            var resltGetQuestions = await _questionsServises.GetQuestionsRandom(Convert.ToInt32(Id));
            questionsCollections = resltGetQuestions;

            questions = questionsCollections.FirstOrDefault();
        }

        protected AnswerOptions intermediateAnswer = new();
        protected void OnChange(int value, int numberQuestions)
        {
            next = false;

            intermediateAnswer.QuestionsId = numberQuestions;
            intermediateAnswer.IdAnswerOptions = value;
        }

        protected IEnumerable<TestResultModel> testResults;
        protected async Task OnClickNext()
        {
            NumperElement++;

            if (answer.Count != 0)
                answer = await GetSession();

            answer.Add(intermediateAnswer);
            await session.SetItemAsync("ResultTest", answer);

            if (questionsCollections.Count > NumperElement)
            {
                answer.Add(intermediateAnswer);
                questions = questionsCollections[NumperElement];
            }
            else
            {
                var result = _answerOptionsServises.TestResults(questionsCollections, answer);
                testResults = result;

                ClearSession();
            }
        }

        protected void OnClickBack()
        {
            NavigationManager.NavigateTo($"/");
        }

        protected async Task<List<AnswerOptions>> GetSession()
        {
            return await session.GetItemAsync<List<AnswerOptions>>("ResultTest");
        }

        protected void ClearSession()
        {
            session.ClearAsync();
        }
    }
}
