public interface ISpinnable
{
    void SpinDisc();
    void StoreData(string d);
    string ReadData();
    string ReportInformation();

    void playContent();
    void extractData();
}