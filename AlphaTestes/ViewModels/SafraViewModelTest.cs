using AlphaStandardDemo.Abstracts;
using AlphaStandardDemo.Models;
using AlphaStandardDemo.ViewModel;
using Moq;
using System.ComponentModel;

namespace AlphaTestes.ViewModels;

public class SafraViewModelTest
{
    private GenericViewModel<Safra> _viewModel;
    private Mock<GenericRepository<Safra>> _mockRepository;
    private BindingList<Safra> _safras;

    [SetUp]
    public void Setup()
    {
        _safras = new BindingList<Safra>
        {
            new Safra { Id = 1, Descricao = "Teste1", Inativo = false, DataInicial = new DateTime(2019, 08, 1), DataFinal = new DateTime(2020, 07, 31) },
            new Safra { Id = 2, Descricao = "Teste2", Inativo = false, DataInicial = new DateTime(2020, 08, 1), DataFinal = new DateTime(2021, 07, 31) },
            new Safra { Id = 3, Descricao = "Teste3", Inativo = false, DataInicial = new DateTime(2021, 08, 1), DataFinal = new DateTime(2022, 07, 31) },
            new Safra { Id = 4, Descricao = "Teste4", Inativo = false, DataInicial = new DateTime(2022, 08, 1), DataFinal = new DateTime(2023, 07, 31) },
            new Safra { Id = 5, Descricao = "Teste5", Inativo = false, DataInicial = new DateTime(2023, 08, 1), DataFinal = new DateTime(2024, 07, 31) }
        };

        _mockRepository = new Mock<GenericRepository<Safra>>();
        _mockRepository.Setup(a => a.Create(It.IsAny<Safra>()));
        _mockRepository.Setup(a => a.Update(It.IsAny<Safra>()));
        _mockRepository.Setup(a => a.Delete(It.IsAny<int>()));
        _mockRepository.Setup(a => a.GetAll()).Returns(_safras);
        _mockRepository.Setup(a => a.GetById(1)).Returns(_safras.First(a => a.Id == 1));
        _mockRepository.Setup(a => a.GetById(2)).Returns(_safras.First(a => a.Id == 2));
        _mockRepository.Setup(a => a.GetById(3)).Returns(_safras.First(a => a.Id == 3));
        _mockRepository.Setup(a => a.GetById(4)).Returns(_safras.First(a => a.Id == 4));
        _mockRepository.Setup(a => a.GetById(5)).Returns(_safras.First(a => a.Id == 5));

        _viewModel = new SafraViewModel(_mockRepository.Object);
    }

    [Test]
    public void CreateCommandTest()
    {
        _viewModel.CreateCommand.Execute(null);

        Assert.That(_viewModel.CurrentItem.Id, Is.EqualTo(0));
        Assert.That(_viewModel.CurrentItem.Descricao, Is.EqualTo(null));
        Assert.That(_viewModel.CurrentItem.Inativo, Is.EqualTo(null));
        Assert.That(_viewModel.CurrentItem.DataInicial, Is.EqualTo(null));
        Assert.That(_viewModel.CurrentItem.DataFinal, Is.EqualTo(null));

        Assert.That(_viewModel.ButtonNewEnabled, Is.False);
        Assert.That(_viewModel.ButtonUpdateEnabled, Is.False);
        Assert.That(_viewModel.ButtonDeleteEnabled, Is.False);
        Assert.That(_viewModel.ButtonCloseEnabled, Is.False);
        Assert.That(_viewModel.ButtonSaveEnabled, Is.True);
        Assert.That(_viewModel.ButtonCancelEnabled, Is.True);
        Assert.Pass();
    }

    [Test]
    public void SaveCommandTest()
    {
        _viewModel.CurrentItem.Descricao = new string('a', 101);

        _viewModel.SaveCommand.Execute(null);

        Assert.That(_viewModel.ListTypeT.Count, Is.EqualTo(5));

        Assert.That(_viewModel.ButtonNewEnabled, Is.True);
        Assert.That(_viewModel.ButtonUpdateEnabled, Is.True);
        Assert.That(_viewModel.ButtonDeleteEnabled, Is.True);
        Assert.That(_viewModel.ButtonCloseEnabled, Is.True);
        Assert.That(_viewModel.ButtonSaveEnabled, Is.False);
        Assert.That(_viewModel.ButtonCancelEnabled, Is.False);
        Assert.Pass();
    }
}