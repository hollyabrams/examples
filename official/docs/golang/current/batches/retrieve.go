package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v5"
)

func retrieve() {
	client := easypost.New("EASYPOST_API_KEY")

	batch, _ := client.GetBatch("batch_...")

	fmt.Println(batch)
}
