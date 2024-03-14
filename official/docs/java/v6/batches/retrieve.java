package batches;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Batch;
import com.easypost.service.EasyPostClient;

public class Retrieve {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        Batch batch = client.batch.retrieve("batch_...");

        System.out.println(batch);
    }
}
