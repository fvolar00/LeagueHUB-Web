export interface ModalProps<P> {
  show: boolean
  handleClose: () => void
  form: P
  onFormChange: (e: { target: { name: any; value: any } }) => void
  submitHandler: (event: any) => void
}
