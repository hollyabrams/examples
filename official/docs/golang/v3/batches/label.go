package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v3"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	batch, _ := client.GetBatchLabels("batch_...", "PDF")

	fmt.Println(batch)
}
