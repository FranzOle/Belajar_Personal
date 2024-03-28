from typing import Final
from telegram import Update
from telegram.ext import Application, CommandHandler, MessageHandler, filters, ContextTypes
import openai

TOKEN: Final ="6411344656:AAEpdcmQ1sm1oOb0AXA1TLuJjiwrPXiQI0k"
BOT_USERNAME: Final = "@Societyco_bot"
openai.api_key = "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"

async def start_command(update: Update, context: ContextTypes.DEFAULT_TYPE):
    await update.message.reply_text("Halooo Welcome to Society Bot")
    
async def help_command(update: Update, context: ContextTypes.DEFAULT_TYPE):
    await update.message.reply_text("I am just bot please start something so i can repond")
    
async def custom_command(update: Update, context: ContextTypes.DEFAULT_TYPE):
    await update.message.reply_text("This is custom command")
    
    
def handle_response(text: str) -> str:
    response = openai.Completion.create(
        engine = "text-davinci-003",  
        prompt = text,
        max_tokens = 1024,  
        n =  1,
        stop = None,
        temperature = 0.7,  
    )
    return response.choices[0].text.strip()

async def handle_message(update: Update, context: ContextTypes.DEFAULT_TYPE):
    message_type: str = update.message.chat.type
    text: str = update.message.text

    print(f'User ({update.message.chat.id}) in {message_type}: "{text}"')

    response = await handle_response(text)
    print('Bot : ', response)
    await update.message.reply_text(response)
    
    
async def error(update: Update, context: ContextTypes.DEFAULT_TYPE):
    print(f'Update{update} caused error {context.error}')
    
    
if __name__ == '__main__':
    print("Starting Bot")
    app = Application.builder().token(TOKEN).build()
    
    app.add_handler(CommandHandler('start', start_command))
    app.add_handler(CommandHandler('help', help_command))
    app.add_handler(CommandHandler('custom', custom_command))

    app.add_handler(MessageHandler(filters.TEXT, handle_message))
    
    app.add_error_handler(error)

    print("Polling....")
    app.run_polling(poll_interval = 5)
    
