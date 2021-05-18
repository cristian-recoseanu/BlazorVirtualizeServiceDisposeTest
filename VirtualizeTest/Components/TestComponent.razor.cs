using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using VirtualizeTest.Data;

namespace VirtualizeTest.Components
{
    public partial class TestComponent
    {
        [Parameter]
        public TestComponentViewModel? ViewModel { get; set; }

        [Inject]
        public ScopedServiceTest? Service { get; set; }

        public List<TestComponentViewModel>? TestComponents;

        protected override void OnInitialized()
        {
            TestComponents = new List<TestComponentViewModel>();

            for (int i = 0; i < 100; i++)
            {
                TestComponents.Add(new TestComponentViewModel(i));
            }

            base.OnInitialized();
        }
    }
}
